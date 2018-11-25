namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Master_Patient_Rule
    {
        [Key]
        [Column(Order = 0)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid RuleId { get; set; }

        [Key]
        [Column(Order = 2)]
        public double PatientId { get; set; }

        public bool? IsSelected { get; set; }
    }
}
