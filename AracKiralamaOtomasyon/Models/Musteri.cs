namespace AracKiralamaOtomasyon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            Kayit = new HashSet<Kayit>();
        }

        public int musteriID { get; set; }

        [StringLength(11)]
        public string tc { get; set; }

        [StringLength(30)]
        public string ad { get; set; }

        [StringLength(30)]
        public string soyad { get; set; }

        [StringLength(11)]
        public string telefon { get; set; }

        [StringLength(100)]
        public string adres { get; set; }

        [StringLength(40)]
        public string email { get; set; }

        [StringLength(6)]
        public string ehliyetSeriNo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ehliyetAlisTarihi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayit> Kayit { get; set; }
    }
}
