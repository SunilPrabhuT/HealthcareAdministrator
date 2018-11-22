namespace Healthcare.Administrator.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SmsLog")]
    public partial class SmsLog
    {
        [Key]
        [StringLength(100)]
        public string SmsId { get; set; }

        [Required]
        [StringLength(500)]
        public string SmsText { get; set; }

        public bool IsRead { get; set; }

        public bool IsSend { get; set; }

        public DateTime Date { get; set; }

        public bool IsActive { get; set; }
    }
}
