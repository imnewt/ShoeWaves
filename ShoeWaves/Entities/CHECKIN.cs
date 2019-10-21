namespace Doann.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHECKIN")]
    public partial class CHECKIN
    {
        [Required]
        [StringLength(5)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string NGAYCHECKIN { get; set; }

        [Key]
        [StringLength(20)]
        public string GIOCHECKIN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
