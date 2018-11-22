namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Master-Rule")]
    public partial class Master_Rule
    {
        public string Id { get; set; }

        [StringLength(10)]
        public string Rule { get; set; }

        [StringLength(128)]
        public string Disease { get; set; }
    }
}
