namespace WebApplication1.Models
{
    public class ClinicModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public List<Doctor>? Employees { get; set; }
    }
}
