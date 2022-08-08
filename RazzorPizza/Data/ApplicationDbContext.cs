using Microsoft.EntityFrameworkCore;
using RazzorPizza.Models;

namespace RazzorPizza.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

    }
}
