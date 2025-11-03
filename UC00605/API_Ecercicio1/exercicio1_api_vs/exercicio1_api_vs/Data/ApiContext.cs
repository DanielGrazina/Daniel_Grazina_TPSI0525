using exercicio1_api_vs.Models;
using Microsoft.EntityFrameworkCore;

namespace exercicio1_api_vs.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Student> Students => Set<Student>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Reservations> Reservations => Set<Reservations>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<TaskItem> Tasks => Set<TaskItem>();
        public DbSet<Costumer> Customers => Set<Costumer>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<StandCars> StandCar { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }
}
