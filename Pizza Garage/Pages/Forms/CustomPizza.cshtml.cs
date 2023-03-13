using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_Garage.Models;

namespace Pizza_Garage.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty] //Binding Pizza with Pizzas Model which will alows us to acces the Pizzas from custom Pizza view
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost() //Called after submit button
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Tuna) PizzaPrice += 1;
            if (Pizza.Pineapple) PizzaPrice += 10;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});

        }
    }
}
