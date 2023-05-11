using Droll.Models;
using Microsoft.EntityFrameworkCore;

namespace Droll.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) :base (option)
        {
            
        }

        public DbSet<Slider> Sliders { get; set; }

       
        public DbSet<Animal> Animals { get; set; }

        public DbSet<DogFood> DogFoods { get; set;}

        public DbSet<FoodImage> FoodImages { get; set; }

    }
}
