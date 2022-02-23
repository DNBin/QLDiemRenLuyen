using System;
using System.Data.Entity;
using QLDiemRenLuyen.Models;

namespace QLDiemRenLuyen.Data
{
    public partial class DataContext : DbContext
    {
        public virtual DbSet<CanBo> CanBos { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<PhieuDanhGia> PhieuDanhGias { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongBao> ThongBaos { get; set; }
        public virtual DbSet<TieuChi> TieuChis { get; set; }

        public DataContext() : base("name=QLDRLConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CanBo>().ToTable("CanBo");
            modelBuilder.Entity<CanBo>().Property(e => e.CanBoId).HasColumnName("CanBoID");
            modelBuilder.Entity<CanBo>().Property(e => e.Block).HasMaxLength(50);
            modelBuilder.Entity<CanBo>().Property(e => e.ChucVuId).HasColumnName("ChucVuID");
            modelBuilder.Entity<CanBo>().Property(e => e.MaGv)
                    .HasMaxLength(500)
                    .HasColumnName("MaGV");
            modelBuilder.Entity<CanBo>().Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            modelBuilder.Entity<CanBo>().HasRequired(d => d.ChucVu)
                    .WithMany(p => p.CanBo)
                    .HasForeignKey(d => d.ChucVuId);
            //.HasConstraintName("FK_CanBo_ChucVu");
            modelBuilder.Entity<CanBo>().HasRequired(d => d.TaiKhoan)
                    .WithMany(p => p.CanBo)
                    .HasForeignKey(d => d.TaiKhoanId);
            //.HasConstraintName("FK_CanBo_TaiKhoan");


            modelBuilder.Entity<ChucVu>().ToTable("ChucVu");
            modelBuilder.Entity<ChucVu>().Property(e => e.ChucVuId).HasColumnName("ChucVuID");
            modelBuilder.Entity<ChucVu>().Property(e => e.TenChucVu).HasMaxLength(500);


            modelBuilder.Entity<Diem>().ToTable("Diem");
            modelBuilder.Entity<Diem>().Property(e => e.DiemId).HasColumnName("DiemID");
            modelBuilder.Entity<Diem>().Property(e => e.DiemCbk).HasColumnName("DiemCBK");
            modelBuilder.Entity<Diem>().Property(e => e.DiemCbl).HasColumnName("DiemCBL");
            modelBuilder.Entity<Diem>().Property(e => e.DiemSv).HasColumnName("DiemSV");
            modelBuilder.Entity<Diem>().Property(e => e.PhieuId).HasColumnName("PhieuID");
            modelBuilder.Entity<Diem>().Property(e => e.TieuChiId).HasColumnName("TieuChiID");
            modelBuilder.Entity<Diem>().HasRequired(d => d.Phieu)
                    .WithMany(p => p.Diem)
                    .HasForeignKey(d => d.PhieuId);
            modelBuilder.Entity<Diem>().HasRequired(d => d.TieuChi)
                    .WithMany(p => p.Diem)
                    .HasForeignKey(d => d.TieuChiId);


            modelBuilder.Entity<Khoa>().ToTable("Khoa");
            modelBuilder.Entity<Khoa>().HasKey(e => e.MaKhoa);
            modelBuilder.Entity<Khoa>().Property(e => e.Block).HasMaxLength(50);
            modelBuilder.Entity<Khoa>().Property(e => e.TenKhoa).HasMaxLength(500);





            modelBuilder.Entity<Lop>().ToTable("Lop");
            modelBuilder.Entity<Lop>().HasKey(e => e.MaLop);
            modelBuilder.Entity<Lop>().Property(e => e.Block).HasMaxLength(50);
            modelBuilder.Entity<Lop>().Property(e => e.TenLop).HasMaxLength(50);
            modelBuilder.Entity<Lop>().HasRequired(d => d.MaKhoaNavigation)
                    .WithMany(p => p.Lop)
                    .HasForeignKey(d => d.MaKhoa);


            modelBuilder.Entity<PhieuDanhGia>().ToTable("PhieuDanhGia");
            modelBuilder.Entity<PhieuDanhGia>().HasKey(e => e.PhieuId);
            modelBuilder.Entity<PhieuDanhGia>().Property(e => e.PhieuId).HasColumnName("PhieuID");
            modelBuilder.Entity<PhieuDanhGia>().Property(e => e.CanBoId).HasColumnName("CanBoID");
            modelBuilder.Entity<PhieuDanhGia>().Property(e => e.CanBoLopId).HasColumnName("CanBoLopID");
            modelBuilder.Entity<PhieuDanhGia>().Property(e => e.NgayDanhGia).HasColumnType("date");
            modelBuilder.Entity<PhieuDanhGia>().Property(e => e.SinhVienId).HasColumnName("SinhVienID");


            modelBuilder.Entity<Quyen>().ToTable("Quyen");
            modelBuilder.Entity<Quyen>().HasKey(e => e.MaQuyen);
            modelBuilder.Entity<Quyen>().Property(e => e.MoTa).HasMaxLength(500);
            modelBuilder.Entity<Quyen>().Property(e => e.TenQuyen).HasMaxLength(500);


            modelBuilder.Entity<SinhVien>().ToTable("SinhVien");
            modelBuilder.Entity<SinhVien>().Property(e => e.SinhVienId).HasColumnName("SinhVienID");
            modelBuilder.Entity<SinhVien>().Property(e => e.Block).HasMaxLength(50);
            modelBuilder.Entity<SinhVien>().Property(e => e.ChucVuId).HasColumnName("ChucVuID");
            modelBuilder.Entity<SinhVien>().Property(e => e.MaSinhVien).HasMaxLength(50);
            modelBuilder.Entity<SinhVien>().Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            modelBuilder.Entity<SinhVien>().HasRequired(d => d.ChucVu)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.ChucVuId);
            modelBuilder.Entity<SinhVien>().HasRequired(d => d.MaLopNavigation)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.MaLop);
            modelBuilder.Entity<SinhVien>().HasRequired(d => d.TaiKhoan)
                    .WithMany(p => p.SinhVien)
                    .HasForeignKey(d => d.TaiKhoanId);


            modelBuilder.Entity<TaiKhoan>().ToTable("TaiKhoan");
            modelBuilder.Entity<TaiKhoan>().Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");
            modelBuilder.Entity<TaiKhoan>().Property(e => e.Block).HasMaxLength(50);
            modelBuilder.Entity<TaiKhoan>().Property(e => e.DiaChi).HasColumnType("ntext");
            modelBuilder.Entity<TaiKhoan>().Property(e => e.Email).HasMaxLength(500);
            modelBuilder.Entity<TaiKhoan>().Property(e => e.GioiTinh).HasMaxLength(500);
            modelBuilder.Entity<TaiKhoan>().Property(e => e.HoTen).HasMaxLength(500);
            modelBuilder.Entity<TaiKhoan>().Property(e => e.MatKhau).HasMaxLength(500);
            modelBuilder.Entity<TaiKhoan>().Property(e => e.NgaySinh).HasColumnType("date");
            modelBuilder.Entity<TaiKhoan>().Property(e => e.NgayTao).HasColumnType("date");
            modelBuilder.Entity<TaiKhoan>().Property(e => e.PhieuId).HasColumnName("PhieuID");
            modelBuilder.Entity<TaiKhoan>().Property(e => e.SoDienThoai).HasMaxLength(50);
            modelBuilder.Entity<TaiKhoan>().Property(e => e.TenTaiKhoan).HasMaxLength(250);
            modelBuilder.Entity<TaiKhoan>().Property(e => e.TrangThai).HasMaxLength(500);
            modelBuilder.Entity<TaiKhoan>().HasRequired(d => d.MaQuyenNavigation)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.MaQuyen);
            modelBuilder.Entity<TaiKhoan>().HasRequired(d => d.Phieu)
                    .WithMany(p => p.TaiKhoan)
                    .HasForeignKey(d => d.PhieuId);
           

            modelBuilder.Entity<ThongBao>().ToTable("ThongBao");
            modelBuilder.Entity<ThongBao>().Property(e => e.ThongBaoId).HasColumnName("ThongBaoID");
            modelBuilder.Entity<ThongBao>().Property(e => e.NgayBdCbk)
                    .HasColumnType("date")
                    .HasColumnName("NgayBD_CBK");
            modelBuilder.Entity<ThongBao>().Property(e => e.NgayBdCbl)
                    .HasColumnType("date")
                    .HasColumnName("NgayBD_CBL");
            modelBuilder.Entity<ThongBao>().Property(e => e.NgayBdSv)
                    .HasColumnType("date")
                    .HasColumnName("NgayBD_SV");
            modelBuilder.Entity<ThongBao>().Property(e => e.NgayKtCbk)
                    .HasColumnType("date")
                    .HasColumnName("NgayKT_CBK");
            modelBuilder.Entity<ThongBao>().Property(e => e.NgayKtCbl)
                    .HasColumnType("date")
                    .HasColumnName("NgayKT_CBL");
            modelBuilder.Entity<ThongBao>().Property(e => e.NgayKtSv)
                    .HasColumnType("date")
                    .HasColumnName("NgayKT_SV");
            modelBuilder.Entity<ThongBao>().Property(e => e.NgayThongBao).HasColumnType("date");
            modelBuilder.Entity<ThongBao>().Property(e => e.NoiDungTb)
                    .HasColumnType("ntext")
                    .HasColumnName("NoiDungTB");
            modelBuilder.Entity<ThongBao>().Property(e => e.PhieuId).HasColumnName("PhieuID");
            modelBuilder.Entity<ThongBao>().Property(e => e.TrangThai).HasMaxLength(50);
            modelBuilder.Entity<ThongBao>().HasRequired(d => d.Phieu)
                    .WithMany(p => p.ThongBao)
                    .HasForeignKey(d => d.PhieuId);


            modelBuilder.Entity<TieuChi>().ToTable("TieuChi");
            modelBuilder.Entity<TieuChi>().Property(e => e.TieuChiId).HasColumnName("TieuChiID");
            modelBuilder.Entity<TieuChi>().Property(e => e.Block).HasMaxLength(50);
            modelBuilder.Entity<TieuChi>().Property(e => e.ParentId).HasColumnName("ParentID");
            modelBuilder.Entity<TieuChi>().Property(e => e.TenTieuChi).HasMaxLength(500);







            //modelBuilder.Entity<CanBo>(entity =>
            //{
            //    entity.Property(e => e.CanBoId).HasColumnName("CanBoID");

            //    entity.Property(e => e.Block).HasMaxLength(50);

            //    entity.Property(e => e.ChucVuId).HasColumnName("ChucVuID");

            //    entity.Property(e => e.MaGv)
            //        .HasMaxLength(500)
            //        .HasColumnName("MaGV");

            //    entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");

            //    entity.HasOne(d => d.ChucVu)
            //        .WithMany(p => p.CanBo)
            //        .HasForeignKey(d => d.ChucVuId)
            //        .HasConstraintName("FK_CanBo_ChucVu");

            //    entity.HasOne(d => d.TaiKhoan)
            //        .WithMany(p => p.CanBo)
            //        .HasForeignKey(d => d.TaiKhoanId)
            //        .HasConstraintName("FK_CanBo_TaiKhoan");
            //});

            //modelBuilder.Entity<ChucVu>(entity =>
            //{
            //    entity.Property(e => e.ChucVuId).HasColumnName("ChucVuID");

            //    entity.Property(e => e.TenChucVu).HasMaxLength(500);
            //});

            //modelBuilder.Entity<Diem>(entity =>
            //{
            //    entity.Property(e => e.DiemId).HasColumnName("DiemID");

            //    entity.Property(e => e.DiemCbk).HasColumnName("DiemCBK");

            //    entity.Property(e => e.DiemCbl).HasColumnName("DiemCBL");

            //    entity.Property(e => e.DiemSv).HasColumnName("DiemSV");

            //    entity.Property(e => e.PhieuId).HasColumnName("PhieuID");

            //    entity.Property(e => e.TieuChiId).HasColumnName("TieuChiID");

            //    entity.HasOne(d => d.Phieu)
            //        .WithMany(p => p.Diem)
            //        .HasForeignKey(d => d.PhieuId)
            //        .HasConstraintName("FK_Diem_PhieuDanhGia");

            //    entity.HasOne(d => d.TieuChi)
            //        .WithMany(p => p.Diem)
            //        .HasForeignKey(d => d.TieuChiId)
            //        .HasConstraintName("FK_Diem_TieuChi");
            //});

            //modelBuilder.Entity<Khoa>(entity =>
            //{
            //    entity.HasKey(e => e.MaKhoa);

            //    entity.Property(e => e.Block).HasMaxLength(50);

            //    entity.Property(e => e.TenKhoa).HasMaxLength(500);
            //});

            //modelBuilder.Entity<KhoaDaoTao>(entity =>
            //{
            //    entity.Property(e => e.KhoaDaoTaoId).HasColumnName("KhoaDaoTaoID");

            //    entity.Property(e => e.NamBd)
            //        .HasColumnType("date")
            //        .HasColumnName("NamBD");

            //    entity.Property(e => e.NamKt)
            //        .HasColumnType("date")
            //        .HasColumnName("NamKT");
            //});

            //modelBuilder.Entity<Lop>(entity =>
            //{
            //    entity.HasKey(e => e.MaLop);

            //    entity.Property(e => e.Block).HasMaxLength(50);

            //    entity.Property(e => e.KhoaDaoTaoId).HasColumnName("KhoaDaoTaoID");

            //    entity.Property(e => e.TenLop).HasMaxLength(50);

            //    entity.HasOne(d => d.KhoaDaoTao)
            //        .WithMany(p => p.Lop)
            //        .HasForeignKey(d => d.KhoaDaoTaoId)
            //        .HasConstraintName("FK_Lop_KhoaDaoTao");

            //    entity.HasOne(d => d.MaKhoaNavigation)
            //        .WithMany(p => p.Lop)
            //        .HasForeignKey(d => d.MaKhoa)
            //        .HasConstraintName("FK_Lop_Khoa");
            //});

            //modelBuilder.Entity<PhieuDanhGia>(entity =>
            //{
            //    entity.HasKey(e => e.PhieuId);

            //    entity.Property(e => e.PhieuId).HasColumnName("PhieuID");

            //    entity.Property(e => e.CanBoId).HasColumnName("CanBoID");

            //    entity.Property(e => e.CanBoLopId).HasColumnName("CanBoLopID");

            //    entity.Property(e => e.NgayDanhGia).HasColumnType("date");

            //    entity.Property(e => e.SinhVienId).HasColumnName("SinhVienID");
            //});

            //modelBuilder.Entity<Quyen>(entity =>
            //{
            //    entity.HasKey(e => e.MaQuyen);

            //    entity.Property(e => e.MoTa).HasMaxLength(500);

            //    entity.Property(e => e.TenQuyen).HasMaxLength(500);
            //});

            //modelBuilder.Entity<SinhVien>(entity =>
            //{
            //    entity.Property(e => e.SinhVienId).HasColumnName("SinhVienID");

            //    entity.Property(e => e.Block).HasMaxLength(50);

            //    entity.Property(e => e.ChucVuId).HasColumnName("ChucVuID");

            //    entity.Property(e => e.MaSinhVien).HasMaxLength(50);

            //    entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");

            //    entity.HasOne(d => d.ChucVu)
            //        .WithMany(p => p.SinhVien)
            //        .HasForeignKey(d => d.ChucVuId)
            //        .HasConstraintName("FK_SinhVien_ChucVu");

            //    entity.HasOne(d => d.MaLopNavigation)
            //        .WithMany(p => p.SinhVien)
            //        .HasForeignKey(d => d.MaLop)
            //        .HasConstraintName("FK_SinhVien_Lop");

            //    entity.HasOne(d => d.TaiKhoan)
            //        .WithMany(p => p.SinhVien)
            //        .HasForeignKey(d => d.TaiKhoanId)
            //        .HasConstraintName("FK_SinhVien_TaiKhoan");
            //});

            //modelBuilder.Entity<TaiKhoan>(entity =>
            //{
            //    entity.Property(e => e.TaiKhoanId).HasColumnName("TaiKhoanID");

            //    entity.Property(e => e.Block).HasMaxLength(50);

            //    entity.Property(e => e.DiaChi).HasColumnType("ntext");

            //    entity.Property(e => e.Email).HasMaxLength(500);

            //    entity.Property(e => e.GioiTinh).HasMaxLength(500);

            //    entity.Property(e => e.HoTen).HasMaxLength(500);

            //    entity.Property(e => e.MatKhau).HasMaxLength(500);

            //    entity.Property(e => e.NgaySinh).HasColumnType("date");

            //    entity.Property(e => e.NgayTao).HasColumnType("date");

            //    entity.Property(e => e.PhieuId).HasColumnName("PhieuID");

            //    entity.Property(e => e.SoDienThoai).HasMaxLength(50);

            //    entity.Property(e => e.TenTaiKhoan).HasMaxLength(250);

            //    entity.Property(e => e.TrangThai).HasMaxLength(500);

            //    entity.HasOne(d => d.MaQuyenNavigation)
            //        .WithMany(p => p.TaiKhoan)
            //        .HasForeignKey(d => d.MaQuyen)
            //        .HasConstraintName("FK_TaiKhoan_Quyen");

            //    entity.HasOne(d => d.Phieu)
            //        .WithMany(p => p.TaiKhoan)
            //        .HasForeignKey(d => d.PhieuId)
            //        .HasConstraintName("FK_TaiKhoan_PhieuDanhGia");
            //});

            //modelBuilder.Entity<ThongBao>(entity =>
            //{
            //    entity.Property(e => e.ThongBaoId).HasColumnName("ThongBaoID");

            //    entity.Property(e => e.NgayBdCbk)
            //        .HasColumnType("date")
            //        .HasColumnName("NgayBD_CBK");

            //    entity.Property(e => e.NgayBdCbl)
            //        .HasColumnType("date")
            //        .HasColumnName("NgayBD_CBL");

            //    entity.Property(e => e.NgayBdSv)
            //        .HasColumnType("date")
            //        .HasColumnName("NgayBD_SV");

            //    entity.Property(e => e.NgayKtCbk)
            //        .HasColumnType("date")
            //        .HasColumnName("NgayKT_CBK");

            //    entity.Property(e => e.NgayKtCbl)
            //        .HasColumnType("date")
            //        .HasColumnName("NgayKT_CBL");

            //    entity.Property(e => e.NgayKtSv)
            //        .HasColumnType("date")
            //        .HasColumnName("NgayKT_SV");

            //    entity.Property(e => e.NgayThongBao).HasColumnType("date");

            //    entity.Property(e => e.NoiDungTb)
            //        .HasColumnType("ntext")
            //        .HasColumnName("NoiDungTB");

            //    entity.Property(e => e.PhieuId).HasColumnName("PhieuID");

            //    entity.Property(e => e.TrangThai).HasMaxLength(50);

            //    entity.HasOne(d => d.Phieu)
            //        .WithMany(p => p.ThongBao)
            //        .HasForeignKey(d => d.PhieuId)
            //        .HasConstraintName("FK_ThongBao_PhieuDanhGia");
            //});

            //modelBuilder.Entity<TieuChi>(entity =>
            //{
            //    entity.Property(e => e.TieuChiId).HasColumnName("TieuChiID");

            //    entity.Property(e => e.Block).HasMaxLength(50);

            //    entity.Property(e => e.ParentId).HasColumnName("ParentID");

            //    entity.Property(e => e.TenTieuChi).HasMaxLength(500);
            //});

            
        }

       
    }
}
