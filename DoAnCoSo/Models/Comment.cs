namespace DoAnCoSo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public int id { get; set; }

        [StringLength(500)]
        public string message { get; set; }

        public DateTime? creation_time { get; set; }

        public int? product_id { get; set; }

        public virtual Product Product { get; set; }
    }
}
