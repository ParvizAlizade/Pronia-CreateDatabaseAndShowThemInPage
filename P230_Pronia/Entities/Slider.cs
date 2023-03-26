using P230_Pronia.Entities;

namespace P230_Pronia.Models
{
    public class Slider :BaseEntity
    {
        public string PlantName { get; set; }
        public string ImagePath { get; set; }
        public double Discount { get; set; }
        public string Desc { get; set; }
        public byte Order { get; set; }
    }
}
