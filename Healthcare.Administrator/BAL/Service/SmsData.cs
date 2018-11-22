using Healthcare.Administrator.BAL.Interface;
using Healthcare.Administrator.DAL.Model;
using Healthcare.Administrator.Interface;
using Healthcare.Administrator.Models.Response;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Healthcare.Administrator.BAL.Service
{  
    public class SmsData : ISmsData
    {
        private readonly string accountSid = ConfigurationManager.AppSettings["Accountsid"].ToString();
        private readonly string authToken = ConfigurationManager.AppSettings["AuthToken"].ToString();
        private readonly string myPhoneNo = ConfigurationManager.AppSettings["myPhoneNo"].ToString();
        private readonly string twillioSandboxNo = ConfigurationManager.AppSettings["twillioSandboxNo"].ToString();


        private readonly IUnitOfWork _iunitofwork;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="unitOfWork"></param>
        public SmsData(IUnitOfWork unitOfWork)
        {
            TwilioClient.Init(accountSid, authToken);
            _iunitofwork = unitOfWork;
        }

        /// <summary></summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public List<string> GetNewReplySms()
        {
            var result = _iunitofwork.SmsLogDataRepository.Get(con => con.IsSend == false && con.IsRead == false).Select(ret => ret.SmsText).ToList();

            foreach (var data in _iunitofwork.SmsLogDataRepository.Get(con => con.IsRead == false).ToList())
            {
                data.IsRead = true;

                _iunitofwork.SmsLogDataRepository.Update(data);
                _iunitofwork.Save();
            }

            return result;
        }
        /// <summary></summary>
        /// <returns></returns>
        /// <remarks></remarks>
        public List<SmsResponseDto> GetAllReplySms()
        {
            var result = _iunitofwork.SmsLogDataRepository.Get(con=>con.IsActive==true).OrderBy(ord=>ord.Date).Select(ret => new SmsResponseDto
            {
                SmsID=ret.SmsId,
                SmsText=ret.SmsText,
                IsSend=ret.IsSend,
                Date=ret.Date
            }).ToList();
          
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="smsId"></param>
        /// <param name="smsText"></param>
        /// <param name="smsDate"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        public bool SaveReplySms(string smsId, string smsText, DateTime smsDate)
        {
            SaveSmstoDB(smsId, smsText, smsDate, false, true);
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageText"></param>       
        /// <returns></returns>
        /// <remarks></remarks>
        public bool SaveSms(string messageText)
        {
            var message = MessageResource.Create(
              body: messageText,
              from: new PhoneNumber(twillioSandboxNo),
              to: new PhoneNumber(myPhoneNo)
           );

            SaveSmstoDB(message.Sid, messageText, DateTime.Now, true, false);
            return true;
        }

        private void SaveSmstoDB(string smsId, string smsText, DateTime smsDate, bool isSend, bool isRcv)
        {
            SmsLog sms = new SmsLog();
            sms.SmsId = smsId;
            sms.SmsText = smsText;
            sms.Date = smsDate;
            sms.IsActive = true;
            if (isRcv)
            {
                sms.IsSend = false;               
                sms.IsRead = false;               
            }
            else
            {
                sms.IsSend = true;             
                sms.IsRead = true;
            }
            _iunitofwork.SmsLogDataRepository.Insert(sms);
            _iunitofwork.Save();
        }
    }
}