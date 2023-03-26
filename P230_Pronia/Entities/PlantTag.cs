namespace P230_Pronia.Entities
{
    public class PlantTag :BaseEntity
    {
        public Plant Plant { get; set; }
        public Tag Tag { get; set; }
    }
}
