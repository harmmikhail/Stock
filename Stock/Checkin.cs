
using System.ComponentModel.DataAnnotations;

namespace Stock
{
    public class Checkin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime LastTimeDelivery { get; set; }
    }
}
