//Safa Atout
//Student#: 991620668
//

namespace PizzaAppSafa.Models
{
    public class PizzaReceipt : PizzaOrder
    {
        public decimal PricePerItem { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }
}
