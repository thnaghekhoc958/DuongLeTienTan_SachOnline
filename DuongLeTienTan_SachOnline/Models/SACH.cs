namespace DuongLeTienTan_SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            BINHLUANs = new HashSet<BINHLUAN>();
            CHITIETDATHANGs = new HashSet<CHITIETDATHANG>();
            GIOHANGs = new HashSet<GIOHANG>();
        }

        [Key]
        public int MaSach { get; set; }

        [Required]
        [StringLength(200)]
        public string TenSach { get; set; }

        public string MoTa { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        [StringLength(255)]
        public string AnhBia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuongBan { get; set; }

        public int? MaCD { get; set; }

        public int? MaNXB { get; set; }

		public string TacGia { get; set; }


		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDATHANG> CHITIETDATHANGs { get; set; }

        public virtual CHUDE CHUDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
    }
}
