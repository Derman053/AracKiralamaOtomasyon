namespace AracKiralamaOtomasyon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kurumsal")]
    public partial class Kurumsal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kurumsal()
        {
            Kayit = new HashSet<Kayit>();
        }

        [Key]
        public int kurumID { get; set; }

        [StringLength(40)]
        public string kurumİsmi { get; set; }

        [StringLength(40)]
        public string kurumAdres { get; set; }

        [StringLength(11)]
        public string kurumTelefon { get; set; }

        [StringLength(40)]
        public string kurumEmail { get; set; }

        [StringLength(10)]
        public string vergiNo { get; set; }

        [StringLength(20)]
        public string muhattap { get; set; }

        [StringLength(11)]
        public string muhattapTelefon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kayit> Kayit { get; set; }
    }
}
