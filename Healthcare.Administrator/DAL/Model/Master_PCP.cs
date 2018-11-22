namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Master_PCP
    {
        public string Id { get; set; }

        [StringLength(128)]
        public string AddressId { get; set; }

        public string PCPName { get; set; }
    }
}
