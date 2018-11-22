namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Master_Patient
    {
        public string Id { get; set; }

        [StringLength(128)]
        public string FirstName { get; set; }

        [StringLength(128)]
        public string LastName { get; set; }

        [Required]
        [StringLength(128)]
        public string AddressId { get; set; }

        public virtual HealthcareAdministrator_Address HealthcareAdministrator_Address { get; set; }
    }
}
