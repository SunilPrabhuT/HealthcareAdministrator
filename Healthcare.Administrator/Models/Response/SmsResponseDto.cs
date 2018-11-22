using System;

namespace Healthcare.Administrator.Models.Response
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class SmsResponseDto
    {
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string SmsID { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string SmsText { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
     //   public string IsRead { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public bool? IsSend { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public DateTime Date { get; set; }     
    }
}