using Microsoft.EntityFrameworkCore;
using Pizza_Garage.Models;

namespace Pizza_Garage.Data
{
    public class ApplicationDBContext : DbContext //Inherited when using ENitty Frmaework

    {
        public DbSet<PizzaOrder> PizzaOrders { get; set;}

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {

        }
    }
}
