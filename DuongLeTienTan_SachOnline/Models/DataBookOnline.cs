using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DuongLeTienTan_SachOnline.Models
{
	public partial class DataBookOnline : DbContext
	{
		public DataBookOnline()
			: base("name=DataBookOnline")
		{
		}

		public virtual DbSet<BINHLUAN> BINHLUANs { get; set; }
		public virtual DbSet<CHITIETDATHANG> CHITIETDATHANGs { get; set; }
		public virtual DbSet<CHUDE> CHUDEs { get; set; }
		public virtual DbSet<DONDATHANG> DONDATHANGs { get; set; }
		public virtual DbSet<GIOHANG> GIOHANGs { get; set; }
		public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
		public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
		public virtual DbSet<SACH> SACHes { get; set; }
		public virtual DbSet<TRANGTHAIDONHANG> TRANGTHAIDONHANGs { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CHITIETDATHANG>()
				.Property(e => e.DonGia)
				.HasPrecision(19, 4);

			modelBuilder.Entity<DONDATHANG>()
				.HasMany(e => e.CHITIETDATHANGs)
				.WithRequired(e => e.DONDATHANG)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<SACH>()
				.Property(e => e.DonGia)
				.HasPrecision(19, 4);

			modelBuilder.Entity<SACH>()
				.HasMany(e => e.CHITIETDATHANGs)
				.WithRequired(e => e.SACH)
				.WillCascadeOnDelete(false);
		}
	}
}
