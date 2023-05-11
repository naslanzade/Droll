using Droll.Models;

namespace Droll.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider>? Sliders { get; set; }
        

        public IEnumerable<Animal>? Animals { get; set; }

        public IEnumerable<DogFood> DogFoods { get; set;}

    }
}
