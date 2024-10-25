using FastAndFurious.Models;
using Microsoft.EntityFrameworkCore;

namespace FastAndFurious.Data
{
public class FastAndFuriousDataContext : DbContext
{
    public FastAndFuriousDataContext(DbContextOptions<FastAndFuriousDataContext> options)
        : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
}

}