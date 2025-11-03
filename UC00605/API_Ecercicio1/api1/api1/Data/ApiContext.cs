using api1.Models;
using Microsoft.EntityFrameworkCore;


namespace sharp_01.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<StandCars> StandCar { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }
    }
}
