//Safa Atout
//Student#: 991620668

using PizzaAppSafa.Models;
namespace PizzaAppSafa.BusinessLayer
{
    public class PizzaService : IPizzaService
    {
        public PizzaReceipt CalculateBill(PizzaOrder order)
        {
            // Step 1: Get base price
            decimal basePrice = GetBasePrice(order.PizzaType, order.Size);

            // Step 2: Subtotal
            decimal subtotal = basePrice * order.Quantity;

            // Step 3: Discount
            // Checked discount calculation

            decimal discount = order.Quantity > 2 ? subtotal * 0.10m : 0;

            // Step 4: Tax (HST 13%)
            decimal taxedAmount = subtotal - discount;
            decimal tax = taxedAmount * 0.13m;

            // Step 5: Final total
            decimal total = taxedAmount + tax;

            // Step 6: Return detailed receipt
            return new PizzaReceipt
            {
                CustomerName = order.CustomerName,
                PizzaType = order.PizzaType,
                Size = order.Size,
                Quantity = order.Quantity,
                PricePerItem = basePrice,
                Subtotal = subtotal,
                Discount = discount,
                Tax = tax,
                Total = total
            };
        }

        private decimal GetBasePrice(string type, string size)
        {
            // Based on the price table from the assignment
            return (type, size) switch
            {
                ("Plain", "Small") => 10,
                ("Plain", "Medium") => 15,
                ("Plain", "Large") => 20,
                ("Crispy", "Small") => 12,
                ("Crispy", "Medium") => 18,
                ("Crispy", "Large") => 25,
                _ => 0 // Default
            };
        }
    }
}
