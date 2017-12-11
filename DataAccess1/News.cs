namespace DataAccess1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        [Key]
        [StringLength(200)]
        public string title { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        [StringLength(50)]
        public string userCreate { get; set; }

        [Required]
        [StringLength(50)]
        public string userModif { get; set; }

        public DateTime creationDate { get; set; }

        public DateTime updateDate { get; set; }

        public virtual users users { get; set; }

        public virtual users users1 { get; set; }
    }
}
