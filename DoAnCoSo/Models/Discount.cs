namespace DoAnCoSo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Discount")]
    public partial class Discount
    {
        public int id { get; set; }

        public int? product_id { get; set; }

        public int? discount_percent { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }
    }
}
