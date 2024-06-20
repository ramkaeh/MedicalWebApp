namespace WebApplication1.Models
{
    public class DoctorClinic
    {

        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}

