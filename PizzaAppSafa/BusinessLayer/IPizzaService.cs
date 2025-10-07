//Safa Atout
//Student#: 991620668

using PizzaAppSafa.Models;

namespace PizzaAppSafa.BusinessLayer
{
    public interface IPizzaService
    {
        PizzaReceipt CalculateBill(PizzaOrder order);
    }
}
