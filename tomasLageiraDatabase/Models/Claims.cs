namespace tomasLageiraDatabase.Models
{
    public class Claims
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public bool? Status { get; set; }
        public DateTime? Date { get; set; }

        public int? Vehicle_Id { get; set; }
        public Vehicles Vehicle { get; set; }

    }
}
