namespace Droll.Models
{
    public class Slider :BaseEntity
    {
        public string ? SliderImage { get; set; }
        public string? Heading { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public string? Value { get; set; }
    }
}
