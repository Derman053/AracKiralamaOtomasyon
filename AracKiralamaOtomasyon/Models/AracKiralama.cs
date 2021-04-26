using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AracKiralamaOtomasyon.Models
{
    public partial class AracKiralama : DbContext
    {
        public AracKiralama()
            : base("name=AracKiralama")
        {
        }

        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<Hasar> Hasar { get; set; }
        public virtual DbSet<Kayit> Kayit { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Kurumsal> Kurumsal { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac>()
                .Property(e => e.plaka)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.marka)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.seri)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.vites)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.renk)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.km)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.yakit)
                .IsUnicode(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.kaskoDurumu)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.tc)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.ad)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.soyad)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.plaka)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.marka)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.seri)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<Hasar>()
                .Property(e => e.aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Kayit>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kayit>()
                .Property(e => e.aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.kullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.sifre)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.ad)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.soyad)
                .IsUnicode(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.tc)
                .IsFixedLength();

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.telefon)
                .IsFixedLength();

            modelBuilder.Entity<Kurumsal>()
                .Property(e => e.kurumİsmi)
                .IsUnicode(false);

            modelBuilder.Entity<Kurumsal>()
                .Property(e => e.kurumAdres)
                .IsUnicode(false);

            modelBuilder.Entity<Kurumsal>()
                .Property(e => e.kurumTelefon)
                .IsFixedLength();

            modelBuilder.Entity<Kurumsal>()
                .Property(e => e.kurumEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Kurumsal>()
                .Property(e => e.vergiNo)
                .IsUnicode(false);

            modelBuilder.Entity<Kurumsal>()
                .Property(e => e.muhattap)
                .IsUnicode(false);

            modelBuilder.Entity<Kurumsal>()
                .Property(e => e.muhattapTelefon)
                .IsFixedLength();

            modelBuilder.Entity<Musteri>()
                .Property(e => e.tc)
                .IsFixedLength();

            modelBuilder.Entity<Musteri>()
                .Property(e => e.ad)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.soyad)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.telefon)
                .IsFixedLength();

            modelBuilder.Entity<Musteri>()
                .Property(e => e.adres)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.ehliyetSeriNo)
                .IsFixedLength();
        }
    }
}
