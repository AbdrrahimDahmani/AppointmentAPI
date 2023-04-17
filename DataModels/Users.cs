namespace AppointmentAPI.DataModels
{
    public class Users
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityInformation { get; set; }
    }
}