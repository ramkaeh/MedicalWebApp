namespace WebApplication1.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public Clinic Clinic { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatinetId { get; set; }
        public Doctor Doctor { get; set; }

        public AppointmentStatus Status {get; set;}
        public enum AppointmentStatus
        {
            Submitted,
            Approved,
            Rejected
        }
    }
}
