namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detail_Tour
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Tour { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Place { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Transport { get; set; }

        public int? Number_Of_Day { get; set; }

        public int? Number_Of_Night { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Departure_Day { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        public virtual Place Place { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual Transport Transport { get; set; }
    }
}
