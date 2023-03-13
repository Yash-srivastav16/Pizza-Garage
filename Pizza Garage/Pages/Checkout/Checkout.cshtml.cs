using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Garage.Data;
using Pizza_Garage.Models;

namespace Pizza_Garage.Pages.Checkout
{
    [BindProperties(SupportsGet =true)] //We will use ies for multiple class Binding 
    public class CheckoutModel : PageModel
    {
        
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDBContext _context;
        public CheckoutModel(ApplicationDBContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            PizzaOrder pizzaOrder = new PizzaOrder();

            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder); //Going to PizzaOrders table and adding the ddata
            _context.SaveChanges(); //Saving the database.
        }
    }
}
