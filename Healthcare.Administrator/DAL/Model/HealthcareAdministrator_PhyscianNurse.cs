namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HealthcareAdministrator_PhyscianNurse
    {
        public string Id { get; set; }

        [StringLength(128)]
        public string RoleId { get; set; }

        [StringLength(400)]
        public string FirstName { get; set; }

        [StringLength(400)]
        public string LastName { get; set; }

        [StringLength(128)]
        public string AddressId { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        [StringLength(128)]
        public string PCPId { get; set; }

        public virtual HealthcareAdministrator_Address HealthcareAdministrator_Address { get; set; }
    }
}
