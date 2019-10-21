namespace Doann.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [StringLength(5)]
        public string MAHD { get; set; }

        [StringLength(30)]
        public string TENKH { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [Required]
        [StringLength(5)]
        public string MAGIAY { get; set; }

        public double? GIA { get; set; }

        [StringLength(20)]
        public string NGAYXUAT { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        public virtual GIAY GIAY { get; set; }
    }
}
