namespace WebApplication1.Models
{
    public class AppointmentModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Location { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int PatinetId { get; set; }
        public int DoctorId { get; set; }

        public AppointmentStatus Status {get; set;}
        public enum AppointmentStatus
        {
            Submitted,
            Approved,
            Rejected
        }
    }
}
