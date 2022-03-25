namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Place")]
    public partial class Place
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Place()
        {
            Detail_Tour = new HashSet<Detail_Tour>();
        }

        [Key]
        public int ID_Place { get; set; }

        public int? ID_Province { get; set; }

        [StringLength(50)]
        public string Name_Place { get; set; }

        [StringLength(1000)]
        public string Text { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail_Tour> Detail_Tour { get; set; }

        public virtual Province Province { get; set; }
    }
}
