namespace AracKiralamaOtomasyon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hasar")]
    public partial class Hasar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hasar()
        {
            Kayit = new HashSet<Kayit>();
        }

        public int hasarID { get; set; }

        [StringLength(11)]
        public string tc { get; set; }

        [StringLength(20)]
        public string ad { get; set; }

        [StringLength(20)]
        public string soyad { get; set; }

        [StringLength(11)]
        public string telefon { get; set; }

        [StringLength(20)]
        public string plaka { get; set; }

        [StringLength(20)]
        public string marka { get; set; }

        [StringLength(20)]
        public string seri { get; set; }

        [StringLength(20)]
        public string model { get; set; }

        public decimal? masraf { get; set; }

        public string aciklama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayit> Kayit { get; set; }
    }
}
