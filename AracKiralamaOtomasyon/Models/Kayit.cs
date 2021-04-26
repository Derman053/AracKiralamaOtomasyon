namespace AracKiralamaOtomasyon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kayit")]
    public partial class Kayit
    {
        public int kayitID { get; set; }

        public int? aracID { get; set; }

        public int? musteriID { get; set; }

        public int? kurumID { get; set; }

        public int? kullaniciID { get; set; }

        public int? hasarID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? islemTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? alisTarih { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? iadeTarih { get; set; }

        public int? alisKm { get; set; }

        public int? iadeKm { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        public string aciklama { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Hasar Hasar { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Kurumsal Kurumsal { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
