namespace DuongLeTienTan_SachOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDATHANG")]
    public partial class CHITIETDATHANG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDH { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSach { get; set; }

        public int SoLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal DonGia { get; set; }

        public virtual SACH SACH { get; set; }

        public virtual DONDATHANG DONDATHANG { get; set; }
    }
}
