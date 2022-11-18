namespace tomasLageiraDatabase.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Vin { get; set; }
        public string? Color { get; set; }
        public int? Year { get; set; }

        public int? Owner_Id { get; set; }
        public Owners? owner { get; set; }

    }
}
