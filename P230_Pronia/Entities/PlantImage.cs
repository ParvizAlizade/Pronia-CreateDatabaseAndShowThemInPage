namespace P230_Pronia.Entities
{
    public class PlantImage :BaseEntity
    {
        public Plant Plant { get; set; }
        public string? Path { get; set; }
        public bool? IsMain { get; set; }
    }
}
