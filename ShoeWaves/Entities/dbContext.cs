namespace Doann.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class dbContext : DbContext
    {
        public dbContext()
            : base("name=dbContext")
        {
        }

        public virtual DbSet<CHECKIN> CHECKINs { get; set; }
        public virtual DbSet<GIAY> GIAYs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHECKIN>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHECKIN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKIN>()
                .Property(e => e.NGAYCHECKIN)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKIN>()
                .Property(e => e.GIOCHECKIN)
                .IsUnicode(false);

            modelBuilder.Entity<GIAY>()
                .Property(e => e.MAGIAY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAY>()
                .Property(e => e.HANG)
                .IsUnicode(false);

            modelBuilder.Entity<GIAY>()
                .Property(e => e.SIZE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIAY>()
                .Property(e => e.NGAYNHAP)
                .IsUnicode(false);

            modelBuilder.Entity<GIAY>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.GIAY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAGIAY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.NGAYXUAT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.PASS)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.CHECKINs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);
        }
    }
}
