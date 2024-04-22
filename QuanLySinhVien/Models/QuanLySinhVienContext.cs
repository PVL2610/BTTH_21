using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVien.Models;

public partial class QuanLySinhVienContext : DbContext
{
    public QuanLySinhVienContext()
    {
    }

    public QuanLySinhVienContext(DbContextOptions<QuanLySinhVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GiaoVien> GiaoViens { get; set; }

    public virtual DbSet<LopSh> LopShes { get; set; }

    public virtual DbSet<LopShSv> LopShSvs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=PVL\\PVL;Initial Catalog=QuanLySinhVien;User ID=sa;Password=26102003;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GiaoVien>(entity =>
        {
            entity.HasKey(e => e.Magv).HasName("PK__GiaoVien__7A2118CD991F5AC8");

            entity.ToTable("GiaoVien");

            entity.Property(e => e.Magv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("magv");
            entity.Property(e => e.Accriht)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accriht");
            entity.Property(e => e.Chucdanh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("chucdanh");
            entity.Property(e => e.Chucvu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("chucvu");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Emaildct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emaildct");
            entity.Property(e => e.Gioitinh).HasColumnName("gioitinh");
            entity.Property(e => e.Hocvi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hocvi");
            entity.Property(e => e.Hotengv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hotengv");
            entity.Property(e => e.Madv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("madv");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Tenviet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tenviet");
            entity.Property(e => e.Website)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("website");
        });

        modelBuilder.Entity<LopSh>(entity =>
        {
            entity.HasKey(e => e.Malsh).HasName("PK__LopSH__15F47670929C9A75");

            entity.ToTable("LopSH");

            entity.Property(e => e.Malsh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("malsh");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ghichu");
            entity.Property(e => e.Hedt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hedt");
            entity.Property(e => e.Hkhienhanh).HasColumnName("hkhienhanh");
            entity.Property(e => e.Khoahoc).HasColumnName("khoahoc");
            entity.Property(e => e.Mabithu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mabithu");
            entity.Property(e => e.Magvcn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("magvcn");
            entity.Property(e => e.Makhoa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("makhoa");
            entity.Property(e => e.Maloppho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maloppho");
            entity.Property(e => e.Maloptruong)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("maloptruong");
            entity.Property(e => e.Manganh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("manganh");
            entity.Property(e => e.Siso).HasColumnName("siso");
            entity.Property(e => e.Slnam).HasColumnName("slnam");
            entity.Property(e => e.Sltt).HasColumnName("sltt");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Tenlsh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tenlsh");
        });

        modelBuilder.Entity<LopShSv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LopSH_SV");

            entity.Property(e => e.Cn2).HasColumnName("cn2");
            entity.Property(e => e.Cursem).HasColumnName("cursem");
            entity.Property(e => e.Ecp).HasColumnName("ecp");
            entity.Property(e => e.Gcp).HasColumnName("gcp");
            entity.Property(e => e.Ghichu)
                .HasColumnType("text")
                .HasColumnName("ghichu");
            entity.Property(e => e.Malsh)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("malsh");
            entity.Property(e => e.Masv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("masv");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Tichluy).HasColumnName("tichluy");

            entity.HasOne(d => d.MalshNavigation).WithMany()
                .HasForeignKey(d => d.Malsh)
                .HasConstraintName("FK__LopSH_SV__malsh__398D8EEE");

            entity.HasOne(d => d.MasvNavigation).WithMany()
                .HasForeignKey(d => d.Masv)
                .HasConstraintName("FK__LopSH_SV__masv__3A81B327");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.Masv).HasName("PK__SinhVien__7A21767C0D8DC239");

            entity.ToTable("SinhVien");

            entity.Property(e => e.Masv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("masv");
            entity.Property(e => e.Accno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("accno");
            entity.Property(e => e.Capdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("capdt");
            entity.Property(e => e.Cdrnn).HasColumnName("cdrnn");
            entity.Property(e => e.Cdrth).HasColumnName("cdrth");
            entity.Property(e => e.Dantoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("dantoc");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.Diemrl).HasColumnName("diemrl");
            entity.Property(e => e.Diemts).HasColumnName("diemts");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Emaildct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emaildct");
            entity.Property(e => e.Ghichu)
                .HasColumnType("text")
                .HasColumnName("ghichu");
            entity.Property(e => e.Ho)
                .HasMaxLength(20)
                .HasColumnName("ho");
            entity.Property(e => e.Ks).HasColumnName("ks");
            entity.Property(e => e.Manh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("manh");
            entity.Property(e => e.Mobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mobile");
            entity.Property(e => e.Noisinh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("noisinh");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Qdtt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("qdtt");
            entity.Property(e => e.Scmnd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scmnd");
            entity.Property(e => e.ScmndImg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("scmnd_img");
            entity.Property(e => e.Specia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("specia");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Ten)
                .HasMaxLength(10)
                .HasColumnName("ten");
            entity.Property(e => e.Tenkd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tenkd");
            entity.Property(e => e.Tenviet)
                .HasMaxLength(10)
                .HasColumnName("tenviet");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
