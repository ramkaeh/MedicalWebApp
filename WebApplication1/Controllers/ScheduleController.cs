using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly WebApplication1Context _context;

        public ScheduleController(WebApplication1Context context)
        {
            _context = context;
        }
        
        [HttpPost("Schedule/ScheduleAppointmentAsync")]
        public async Task<IActionResult> ScheduleAppointmentAsync([FromBody] JObject data )
        {
            if(data ==null)
            {
                // Log the issue
                return Json(new { success = false, message = "Model is null. Check the data sent in the request." });
            }
            var model = data.ToObject<AppointmentViewModel>();

            
                var appointment = new Appointment
                {
                    Title = model.Title,
                    ClinicId = model.Clinic.Id,
                        DoctorId = model.Doctor.Id,
                    BookDate =DateTime.Now,
                    AppointmentDate = model.AppointmentDate 
                };

                _context.Appointments.Add(appointment);
                // Zapisanie zmian w bazie danych
                await _context.SaveChangesAsync();

                // Zwrócenie odpowiedzi JSON
                return Json(new { success = true, message = "Appointment scheduled successfully!" });

            


            return Json(new { success = false, message = "Error " });
        }
        public IActionResult Index()
        {
            var clinics = _context.Clinics
                .Select(d => new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name + " " + d.Location
                })
                              .ToList();

            ViewBag.Clinics = clinics;

            var doctors = _context.Doctors
                .Select(d => new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name + " " + d.Surname
                })
                              .ToList();

            ViewBag.Doctors = doctors;

            return View();
        }

        
    }
}
