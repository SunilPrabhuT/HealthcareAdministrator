using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Healthcare.Administrator.Models.Response
{
    /// <summary>
    /// PatientRuleResponseDto
    /// </summary>
    public class PatientMedicationRuleResponseDto
    {
        /// <summary>
        /// Medication field
        /// </summary>
        public string Medication { get; set; }
        /// <summary>
        /// IsMorningrequired field
        /// </summary>
        public bool IsMorningrequired  { get; set; }
        /// <summary> 
        /// IsAfternoonrequired field
        /// </summary>
        public string IsAfternoonrequired { get; set; }
        /// <summary>
        /// IsEveningrequired field
        /// </summary>
        public string IsEveningrequired { get; set; }
    }
}