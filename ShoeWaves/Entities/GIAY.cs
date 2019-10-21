namespace Doann.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAY")]
    public partial class GIAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAY()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(5)]
        public string MAGIAY { get; set; }

        [Required]
        [StringLength(10)]
        public string HANG { get; set; }

        [StringLength(3)]
        public string SIZE { get; set; }

        public double? GIA { get; set; }

        [StringLength(50)]
        public string GHICHU { get; set; }

        [StringLength(20)]
        public string NGAYNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
