namespace Doann.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            CHECKINs = new HashSet<CHECKIN>();
        }

        [StringLength(5)]
        public string ID { get; set; }

        [Required]
        [StringLength(20)]
        public string NAME { get; set; }

        [Required]
        [StringLength(20)]
        public string PASS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECKIN> CHECKINs { get; set; }
    }
}
