namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PatientPopulationData")]
    public partial class PatientPopulationData
    {
        [Key]
        [Column("Sl No")]
        public double Sl_No { get; set; }

        [Column("Patient Name")]
        [StringLength(255)]
        public string Patient_Name { get; set; }

        [Column("Member / Dependent")]
        [StringLength(255)]
        public string Member___Dependent { get; set; }

        [StringLength(255)]
        public string Gender { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(255)]
        public string County { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        public double? ZipCode { get; set; }

        [StringLength(255)]
        public string PCP { get; set; }

        public double? BMI { get; set; }

        [Column("Diabetes Level")]
        public double? Diabetes_Level { get; set; }

        public double? systolic { get; set; }

        public double? Diastolic { get; set; }

        [StringLength(255)]
        public string Smoking { get; set; }

        [Column("Phy Name")]
        [StringLength(255)]
        public string Phy_Name { get; set; }

        [Column("Nurse Name")]
        [StringLength(255)]
        public string Nurse_Name { get; set; }

        [Column("Initial (First) Findings")]
        [StringLength(255)]
        public string Initial__First__Findings { get; set; }

        [Column("Previous Findings 1")]
        [StringLength(255)]
        public string Previous_Findings_1 { get; set; }

        [StringLength(255)]
        public string Date { get; set; }

        [Column("Previous Findings 2")]
        [StringLength(255)]
        public string Previous_Findings_2 { get; set; }

        [StringLength(255)]
        public string Date1 { get; set; }

        [Column("Previous Findings 3")]
        [StringLength(255)]
        public string Previous_Findings_3 { get; set; }

        [StringLength(255)]
        public string Date2 { get; set; }

        [Column("Previous Findings 4")]
        [StringLength(255)]
        public string Previous_Findings_4 { get; set; }

        [StringLength(255)]
        public string Date3 { get; set; }

        [Column("Current Findings")]
        [StringLength(255)]
        public string Current_Findings { get; set; }

        [StringLength(255)]
        public string Date4 { get; set; }

        [Column("Final Requirement")]
        [StringLength(255)]
        public string Final_Requirement { get; set; }
    }
}
