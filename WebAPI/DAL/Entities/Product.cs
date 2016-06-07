namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }

        public double? Price { get; set; }

        [StringLength(200)]
        public string ProductImage { get; set; }

        public string Description { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
