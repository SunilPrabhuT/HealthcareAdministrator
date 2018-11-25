using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Healthcare.Administrator.Models.Response
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks></remarks>
    public class PatientRuleResponseDto
    {
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public Guid ID { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public Guid RuleId { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public double PatientID { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public string RuleName { get; set; }
        /// <summary>
        /// Gets or sets a value for IsSelected
        /// </summary>
        /// <values>
        ///   <see langword="true" /> if this instance ; otherwise, <see langword="false" />.</value>
        /// <remarks></remarks>
        public bool IsSelected { get; set; }

    }
}