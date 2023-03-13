using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Garage.Data;
using Pizza_Garage.Models;

namespace Pizza_Garage.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> pizzaOrders = new List<PizzaOrder>();
        private readonly ApplicationDBContext _context;
        public  OrdersModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            pizzaOrders = _context.PizzaOrders.ToList(); //getting from table and storing in list
            pizzaOrders.Reverse();
        }
    }
}
