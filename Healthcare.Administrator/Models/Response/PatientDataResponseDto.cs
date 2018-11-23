using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Healthcare.Administrator.Models.Response
{
    /// <summary>
    /// PatientDataResponseDto
    /// </summary>
    public class PatientDataResponseDto
    {
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public double PatientId { get; set; }
        /// <summary>
        /// PatientName field
        /// </summary>
        public string PatientName { get; set; }
        /// <summary>
        /// MemberDependent field
        /// </summary>
        public string MemberDependent { get; set; }
        /// <summary>
        /// Gender field
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// DOB Field
        /// </summary>
        public string DOB { get; set; }
        /// <summary>
        /// Country Field
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// City Field
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// State Field
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// ZipCode field
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// PCP field
        /// </summary>
        public string PCP { get; set; }
        /// <summary>
        /// BMI field
        /// </summary>
        public string BMI { get; set; }
        /// <summary>
        /// DiabetesLevel field
        /// </summary>
        public string DiabetesLevel { get; set; }
        /// <summary>
        /// Systolic field
        /// </summary>
        public string Systolic { get; set; }
        /// <summary>
        /// Diastolic field
        /// </summary>
        public string Diastolic { get; set; }
        /// <summary>
        /// Smoking field
        /// </summary>
        public string Smoking { get; set; }
        /// <summary>
        /// Pyscian field
        /// </summary>
        public string Pyscian { get; set; }
        /// <summary>
        /// Nurse field
        /// </summary>
        public string Nurse { get; set; }
        /// <summary>
        /// InitialFinding1 field
        /// </summary>
        public string InitialFinding1 { get; set; }
        /// <summary>
        /// PreviousFinding1 field
        /// </summary>
        public string PreviousFinding1 { get; set; }
        /// <summary>
        /// PreviousFinding2 field
        /// </summary>
        public string PreviousFinding2 { get; set; }
        /// <summary>
        /// PreviousFinding3 field
        /// </summary>
        public string PreviousFinding3 { get; set; }
        /// <summary>
        /// PreviousFinding4 field
        /// </summary>
        public string PreviousFinding4 { get; set; }
        /// <summary>
        /// PreviousFinding4 field
        /// </summary>
        public string CurrentFindings { get; set; }
        /// <summary>
        /// CurrentFindings field
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Date1 field
        /// </summary>
        public string Date1 { get; set; }
        /// <summary>
        /// Date2 field
        /// </summary>
        public string Date2 { get; set; }
        /// <summary>
        /// Date3 field
        /// </summary>
        public string Date3 { get; set; }
        /// <summary>
        /// Date4 field
        /// </summary>
        public string Date4 { get; set; }
        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public List<PatientRuleResponseDto> PatientRuleList { get; set; }
    }
}