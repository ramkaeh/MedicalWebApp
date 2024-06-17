namespace WebApplication1.Models
{
    public class Patient
    {   
        public int Id { get; set; }

        private string? OwnerID;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }

        
    }
}
