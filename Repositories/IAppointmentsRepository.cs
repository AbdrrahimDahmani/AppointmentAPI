using AppointmentAPI.DataModels;

namespace AppointmentAPI.Repositories
{
    public interface IAppointmentsRepository
    {
        Task<List<Appointments>> GetAppointments();
        Task<Appointments> GetAppointment(int id);
    }
}