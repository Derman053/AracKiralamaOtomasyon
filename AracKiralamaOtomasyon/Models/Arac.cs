namespace AracKiralamaOtomasyon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arac")]
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            Kayit = new HashSet<Kayit>();
        }

        public int aracID { get; set; }

        [StringLength(20)]
        public string plaka { get; set; }

        [StringLength(20)]
        public string marka { get; set; }

        [StringLength(20)]
        public string seri { get; set; }

        [StringLength(20)]
        public string model { get; set; }

        [StringLength(20)]
        public string vites { get; set; }

        [StringLength(20)]
        public string renk { get; set; }

        [StringLength(20)]
        public string km { get; set; }

        [StringLength(20)]
        public string yakit { get; set; }

        [StringLength(20)]
        public string kaskoDurumu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayit> Kayit { get; set; }
    }
}
