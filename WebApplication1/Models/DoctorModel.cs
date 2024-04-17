using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int age {  get; set; }   
    public Boolean Sex { get; set; }
    public string Major {  get; set; }
}
