namespace data.entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductJunction")]
    public partial class ProductJunction
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int ProductTypeId { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
