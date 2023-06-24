using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class ProductInfo
    {
        public static List<ProductInfo> AddedProducts { get; set; } = new List<ProductInfo>();

        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime DeliveryDate { get; set; }

        public static void ClearAddedProducts()
        {
            AddedProducts.Clear();
        }
    }
}
