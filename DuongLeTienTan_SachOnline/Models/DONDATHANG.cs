namespace DuongLeTienTan_SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONDATHANG")]
    public partial class DONDATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONDATHANG()
        {
            CHITIETDATHANGs = new HashSet<CHITIETDATHANG>();
        }

        [Key]
        public int MaDH { get; set; }

        public int? MaND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        public int? MaTrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDATHANG> CHITIETDATHANGs { get; set; }

        public virtual TRANGTHAIDONHANG TRANGTHAIDONHANG { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
