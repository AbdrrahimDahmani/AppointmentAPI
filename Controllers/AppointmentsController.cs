using AppointmentAPI.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AppointmentAPI.DomainModels;
namespace AppointmentAPI.Controllers
{
    [ApiController]
    public class AppointmentsController : Controller
    {
        private readonly IAppointmentsRepository appointmentsRepository;
        private readonly IMapper mapper;

        public AppointmentsController(IAppointmentsRepository appointmentsRepository, IMapper mapper)
        {
            this.appointmentsRepository = appointmentsRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("/appointments")]
        public async Task<IActionResult> allAppointments()
        {
            var appointments = await this.appointmentsRepository.GetAppointments();

            return Ok(this.mapper.Map<List<Appointments>>(appointments));
        }
        [HttpGet]
        [Route("/appointments/{id:int}")]
        public async Task<IActionResult> getAppointment(int id)
        {
            var appointment = await this.appointmentsRepository.GetAppointment(id);

            if (appointment == null)
            {
                return NotFound();
            }

            return Ok(this.mapper.Map<Appointments>(appointment));
        }
    }
}
