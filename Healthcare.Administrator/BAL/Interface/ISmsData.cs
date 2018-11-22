using Healthcare.Administrator.Models.Response;
using System;
using System.Collections.Generic;

namespace Healthcare.Administrator.BAL.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public interface ISmsData
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageText"></param>
        /// /// <param name="smsId"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        bool SaveSms(string messageText);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        bool SaveReplySms(string smsId, string smsText, DateTime smsDate);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        List<string> GetNewReplySms();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        List<SmsResponseDto> GetAllReplySms();
    }
}
