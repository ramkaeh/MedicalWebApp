using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly WebApplication1Context _context;

        public ScheduleController(WebApplication1Context context)
        {
            _context = context;
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

        [HttpPost]
        public async Task<IActionResult> ScheduleAppointmentAsync([FromBody] AppointmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var appointment = new Appointment
                {
                    Title = model.Title,
                    Clinic = model.Clinic,
                    Doctor = model.Doctor,
                    BookDate =DateTime.Now,
                    AppointmentDate = model.Date
                };

                _context.Appointments.Add(appointment);
                // Zapisanie zmian w bazie danych
                await _context.SaveChangesAsync();

                // Zwrócenie odpowiedzi JSON
                return Json(new { success = true, message = "Appointment scheduled successfully!" });

            }


            return Json(new { success = false, message = "Error 1" });
        }
    }
}
