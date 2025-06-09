namespace DuongLeTienTan_SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BINHLUAN")]
    public partial class BINHLUAN
    {
        [Key]
        public int MaBL { get; set; }

        public int? MaND { get; set; }

        public int? MaSach { get; set; }

        public string NoiDung { get; set; }

        public int? DiemDanhGia { get; set; }

        public DateTime? NgayBinhLuan { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
