namespace WebApplication1.Models
{
    public class AppointmentViewModel
    {
        public string Title { get; set; }
        public Clinic Clinic { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
    }
}
