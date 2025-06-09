namespace DuongLeTienTan_SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANGTHAIDONHANG")]
    public partial class TRANGTHAIDONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANGTHAIDONHANG()
        {
            DONDATHANGs = new HashSet<DONDATHANG>();
        }

        [Key]
        public int MaTrangThai { get; set; }

        [Required]
        [StringLength(100)]
        public string TenTrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONDATHANG> DONDATHANGs { get; set; }
    }
}
