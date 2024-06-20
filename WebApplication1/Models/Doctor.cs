using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Doctor
{
    
    public int Id { get; set; }
    public string? OwnerId { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    [Range(25, 65, ErrorMessage = "Age must be between 25 and 65")]
    public int Age {  get; set; }
    
    public string? Gender { get; set; }
    public string? Major {  get; set; }
    public List<DoctorClinic>? DoctorClinics { get; set; } 

}
