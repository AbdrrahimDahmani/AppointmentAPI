using AppointmentAPI.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AppointmentAPI.Repositories
{
    public class AppointmentsRepository : IAppointmentsRepository
    {
        private readonly AppointmentsManagementContext context;
        public AppointmentsRepository(AppointmentsManagementContext context)
        {
            this.context = context;
        }

        public async Task<Appointments> GetAppointment(int id)
        {
            return await this.context.Appointments.Include(a => a.UserInfo)
                                    .Include(a => a.Calendar)
                                    .FirstOrDefaultAsync(x => x.AppointmentId == id);
        }

        public async Task<List<Appointments>> GetAppointments()
        {
            return await this.context.Appointments.Include(a => a.UserInfo).Include(a => a.Calendar).ToListAsync();
        }
    }
}