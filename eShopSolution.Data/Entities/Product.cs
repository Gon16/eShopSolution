using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public String SeoAlias { set; get; }

        public List<ProductInCategory> ProductInCategory { get; set; }

        public List<OrderDetail> OrderDetail { get; set; }

        public List<ProductTranslation> productTranslation { get; set; }
        public List<Cart> Cart { get; set; }
    }
}
