namespace QLNhaKho
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLKhoDbContext : DbContext
    {
        public QLKhoDbContext()
            : base("name=QLKhoDbContext")
        {
        }

        public virtual DbSet<ChiTietHangHoa> ChiTietHangHoas { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<DiaDiem> DiaDiems { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<Nhansu> Nhansus { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.ChiTietHangHoas)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HangHoa>()
                .HasMany(e => e.PhieuXuats)
                .WithRequired(e => e.HangHoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.PhieuXuats)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kho>()
                .HasMany(e => e.ChiTietHangHoas)
                .WithRequired(e => e.Kho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.NhaCungCap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nhansu>()
                .Property(e => e.sdt)
                .IsUnicode(false);
        }
    }
}
