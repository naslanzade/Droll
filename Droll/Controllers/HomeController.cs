using Droll.Data;
using Droll.Models;
using Droll.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Droll.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult>  Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.Where(m => !m.SoftDeleted).ToListAsync();
            IEnumerable<Animal> animals = await _context.Animals.Where(m => !m.SoftDeleted).ToArrayAsync();
            IEnumerable<DogFood> dogFoods = await _context.DogFoods.Include(m => m.Images).Where(m => !m.SoftDeleted).ToArrayAsync();

            HomeVM homeVM = new()
            {
                Sliders= sliders,
                Animals=animals,
                DogFoods=dogFoods

            };
            return View(homeVM);
        }
    }
}
