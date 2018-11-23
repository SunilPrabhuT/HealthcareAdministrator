namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Master_Rule
    {
        public Guid Id { get; set; }

        [StringLength(500)]
        public string Rules { get; set; }

        public Guid? DiseaseId { get; set; }

        public virtual Master_Diseases Master_Diseases { get; set; }
    }
}
