using System;
using System.Web.Http;
using Twilio.AspNet.Common;
using Healthcare.Administrator.BAL.Interface;

namespace Healthcare.Administrator.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    [RoutePrefix("api/SMS")]
    public class SMSController : ApiController
    {        
        private readonly ISmsData _iSmsData;
        /// <summary>
        /// Initializes a new instance of the <see cref="Healthcare.Administrator.Controllers.SMSController" /> class. 
        /// </summary>
        /// <remarks></remarks>
        public SMSController(ISmsData smsData)
        {          
            _iSmsData = smsData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        [HttpPost]
        //[Authorize]
        [Route("SendSMS")]
        public IHttpActionResult SendSMS(string messageText)
        {
            return Ok(_iSmsData.SaveSms(messageText));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomingMessage"></param>
        /// <returns></returns>
        /// <remarks></remarks>    
        [Route("ReceiveSMS")]
        //[Authorize]
        public IHttpActionResult ReceiveSMS(SmsRequest incomingMessage)
        {
            _iSmsData.SaveReplySms(incomingMessage.SmsSid, incomingMessage.Body, DateTime.Now);
            return Ok(incomingMessage.Body);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        [HttpGet]
        //[Authorize]
        [Route("GetReplySms")]
        public IHttpActionResult GetReplySMS()
        {
            return Ok(_iSmsData.GetAllReplySms());
        }
    }
}
