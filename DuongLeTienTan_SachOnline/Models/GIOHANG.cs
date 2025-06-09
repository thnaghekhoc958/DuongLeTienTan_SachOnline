namespace DuongLeTienTan_SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIOHANG")]
    public partial class GIOHANG
    {
        [Key]
        public int MaGH { get; set; }

        public int? MaND { get; set; }

        public int? MaSach { get; set; }

        public int SoLuong { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
