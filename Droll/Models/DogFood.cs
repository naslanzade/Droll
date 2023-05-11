namespace Droll.Models
{
    public class DogFood :BaseEntity
    {
        public string ? Name { get; set; }        
        public decimal ? Price { get; set; }
        public ICollection<FoodImage> ? Images { get; set; }  
    }
}
