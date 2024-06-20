namespace WebApplication1.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public List<DoctorClinic>? DoctorClinics { get; set; }
    }
}
