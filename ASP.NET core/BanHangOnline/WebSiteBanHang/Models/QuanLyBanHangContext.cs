using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebSiteBanHang.Models
{
    public partial class QuanLyBanHangContext : DbContext
    {
        public QuanLyBanHangContext()
        {
        }

        public QuanLyBanHangContext(DbContextOptions<QuanLyBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BinhLuan> BinhLuan { get; set; }
        public virtual DbSet<ChiTietDonDatHang> ChiTietDonDatHang { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }
        public virtual DbSet<DonDatHang> DonDatHang { get; set; }
        public virtual DbSet<GioHangTam> GioHangTam { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public virtual DbSet<LoaiThanhVien> LoaiThanhVien { get; set; }
        public virtual DbSet<LoaiThanhVienQuyen> LoaiThanhVienQuyen { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuat { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhap { get; set; }
        public virtual DbSet<Quyen> Quyen { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<ThanhVienTb> ThanhVienTb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=QuanLyBanHang;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BinhLuan>(entity =>
            {
                entity.HasKey(e => e.MaBl);

                entity.Property(e => e.MaBl).HasColumnName("MaBL");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.NoiDungBl).HasColumnName("NoiDungBL");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.BinhLuan)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BinhLuan_SanPham");

                entity.HasOne(d => d.MaThanhVienNavigation)
                    .WithMany(p => p.BinhLuan)
                    .HasForeignKey(d => d.MaThanhVien)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BinhLuan_ThanhVienTB");
            });

            modelBuilder.Entity<ChiTietDonDatHang>(entity =>
            {
                entity.HasKey(e => e.MaChiTietDdh);

                entity.Property(e => e.MaChiTietDdh).HasColumnName("MaChiTietDDH");

                entity.Property(e => e.DaXoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MaDdh).HasColumnName("MaDDH");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.TenSp)
                    .HasColumnName("TenSP")
                    .HasMaxLength(255);

                entity.HasOne(d => d.MaDdhNavigation)
                    .WithMany(p => p.ChiTietDonDatHang)
                    .HasForeignKey(d => d.MaDdh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChiTietDonDatHang_DonDatHang");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietDonDatHang)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChiTietDonDatHang_SanPham");
            });

            modelBuilder.Entity<ChiTietPhieuNhap>(entity =>
            {
                entity.HasKey(e => e.MaChiTietPn);

                entity.Property(e => e.MaChiTietPn).HasColumnName("MaChiTietPN");

                entity.Property(e => e.DaXoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGiaNhap)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaPn).HasColumnName("MaPN");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.SoLuongNhap).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MaPnNavigation)
                    .WithMany(p => p.ChiTietPhieuNhap)
                    .HasForeignKey(d => d.MaPn)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChiTietPhieuNhap_PhieuNhap");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietPhieuNhap)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChiTietPhieuNhap_SanPham");
            });

            modelBuilder.Entity<DonDatHang>(entity =>
            {
                entity.HasKey(e => e.MaDdh);

                entity.Property(e => e.MaDdh).HasColumnName("MaDDH");

                entity.Property(e => e.DaHuy).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaThanhToan).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaXoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.NgayDat).HasColumnType("datetime");

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.Property(e => e.TinhTrangGiaoHang).HasDefaultValueSql("((0))");

                entity.Property(e => e.UuDai).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DonDatHang)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DonDatHang_KhachHang");
            });

            modelBuilder.Entity<GioHangTam>(entity =>
            {
                entity.HasKey(e => new { e.MaTv, e.MaSp });

                entity.Property(e => e.MaTv).HasColumnName("MaTV");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.MaThanhVien).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SoDienThoai).HasMaxLength(255);

                entity.Property(e => e.TenKh)
                    .HasColumnName("TenKH")
                    .HasMaxLength(100);

                entity.Property(e => e.Xoa).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSp);

                entity.Property(e => e.MaLoaiSp).HasColumnName("MaLoaiSP");

                entity.Property(e => e.BiDanh).HasMaxLength(50);

                entity.Property(e => e.TenLoai).HasMaxLength(100);
            });

            modelBuilder.Entity<LoaiThanhVien>(entity =>
            {
                entity.HasKey(e => e.MaLoaiTv);

                entity.Property(e => e.MaLoaiTv)
                    .HasColumnName("MaLoaiTV")
                    .ValueGeneratedNever();

                entity.Property(e => e.TenLoai).HasMaxLength(50);

                entity.Property(e => e.UuDai).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<LoaiThanhVienQuyen>(entity =>
            {
                entity.HasKey(e => new { e.MaLoaiTv, e.MaQuyen });

                entity.ToTable("LoaiThanhVien_Quyen");

                entity.Property(e => e.MaLoaiTv).HasColumnName("MaLoaiTV");

                entity.Property(e => e.MaQuyen).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(50);

                entity.HasOne(d => d.MaLoaiTvNavigation)
                    .WithMany(p => p.LoaiThanhVienQuyen)
                    .HasForeignKey(d => d.MaLoaiTv)
                    .HasConstraintName("FK_LoaiThanhVien_Quyen_LoaiThanhVien");

                entity.HasOne(d => d.MaQuyenNavigation)
                    .WithMany(p => p.LoaiThanhVienQuyen)
                    .HasForeignKey(d => d.MaQuyen)
                    .HasConstraintName("FK_LoaiThanhVien_Quyen_Quyen");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNcc);

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TenNcc)
                    .HasColumnName("TenNCC")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<NhaSanXuat>(entity =>
            {
                entity.HasKey(e => e.MaNsx);

                entity.Property(e => e.MaNsx).HasColumnName("MaNSX");

                entity.Property(e => e.TenNsx)
                    .HasColumnName("TenNSX")
                    .HasMaxLength(100);

                entity.Property(e => e.ThongTin).HasMaxLength(255);
            });

            modelBuilder.Entity<PhieuNhap>(entity =>
            {
                entity.HasKey(e => e.MaPn);

                entity.Property(e => e.MaPn).HasColumnName("MaPN");

                entity.Property(e => e.DaXoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.NgayNhap).HasColumnType("datetime");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.PhieuNhap)
                    .HasForeignKey(d => d.MaNcc)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PhieuNhap_ToTable");
            });

            modelBuilder.Entity<Quyen>(entity =>
            {
                entity.HasKey(e => e.MaQuyen);

                entity.Property(e => e.MaQuyen)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.TenQuyen).HasMaxLength(50);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.CauHinh).HasDefaultValueSql("('rong')");

                entity.Property(e => e.DaXoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.DonGia)
                    .HasColumnType("decimal(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HinhAnh).HasDefaultValueSql("('rong')");

                entity.Property(e => e.HinhAnh1).HasDefaultValueSql("('rong')");

                entity.Property(e => e.HinhAnh2).HasDefaultValueSql("('rong')");

                entity.Property(e => e.HinhAnh3).HasDefaultValueSql("('rong')");

                entity.Property(e => e.HinhAnh4).HasDefaultValueSql("('rong')");

                entity.Property(e => e.LuotBinhChon).HasDefaultValueSql("((0))");

                entity.Property(e => e.LuotBinhLuan).HasDefaultValueSql("((0))");

                entity.Property(e => e.LuotXem).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaLoaiSp).HasColumnName("MaLoaiSP");

                entity.Property(e => e.MaNcc).HasColumnName("MaNCC");

                entity.Property(e => e.MaNsx).HasColumnName("MaNSX");

                entity.Property(e => e.MoTa).HasDefaultValueSql("('rong')");

                entity.Property(e => e.Moi).HasDefaultValueSql("((1))");

                entity.Property(e => e.NgayCapNhap).HasColumnType("datetime");

                entity.Property(e => e.SoLanMua).HasDefaultValueSql("((0))");

                entity.Property(e => e.SoLuongTon).HasDefaultValueSql("((0))");

                entity.Property(e => e.TenSp)
                    .HasColumnName("TenSP")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('chua dat ten')");

                entity.HasOne(d => d.MaLoaiSpNavigation)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.MaLoaiSp)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SanPham_LoaiSP");

                entity.HasOne(d => d.MaNccNavigation)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.MaNcc)
                    .HasConstraintName("FK_SanPham_NhaCungCap");

                entity.HasOne(d => d.MaNsxNavigation)
                    .WithMany(p => p.SanPham)
                    .HasForeignKey(d => d.MaNsx)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SanPham_NhaSanXuat");
            });

            modelBuilder.Entity<ThanhVienTb>(entity =>
            {
                entity.HasKey(e => e.MaThanhVien);

                entity.ToTable("ThanhVienTB");

                entity.Property(e => e.DaXoa).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiaChi).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.HoTen).HasMaxLength(100);

                entity.Property(e => e.MaLoaiTv)
                    .HasColumnName("MaLoaiTV")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.MatKhau).HasMaxLength(100);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan).HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiTvNavigation)
                    .WithMany(p => p.ThanhVienTb)
                    .HasForeignKey(d => d.MaLoaiTv)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ThanhVienTB_ToTable");
            });
        }
    }
}
