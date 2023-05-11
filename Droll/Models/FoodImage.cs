namespace Droll.Models
{
    public class FoodImage :BaseEntity
    {
        public string ? Image { get; set; }

        public int DogFoodId { get; set; }

        public DogFood ? DogFood { get; set; }

        public bool IsMain { get; set; }
             
    }
}
