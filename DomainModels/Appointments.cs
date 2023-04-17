
namespace AppointmentAPI.DomainModels
{
    public class Appointments
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public String Time { get; set; }
        public int UserId { get; set; }
        public Users UserInfo { get; set; }

        public Guid CalendarCode { get; set; }
        public virtual Calendars Calendar { get; set; }

    }
}
