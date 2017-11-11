namespace Lab1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tourist")]
    public partial class Tourist
    {
        [Key]
        public long Tourist_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        public short Age { get; set; }
    }
}
