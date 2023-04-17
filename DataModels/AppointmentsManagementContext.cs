using Microsoft.EntityFrameworkCore;

namespace AppointmentAPI.DataModels
{
    public class AppointmentsManagementContext : DbContext
    {

        public AppointmentsManagementContext(DbContextOptions<AppointmentsManagementContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointments>().HasKey(a => a.AppointmentId);

            modelBuilder.Entity<Calendars>().HasKey(a => a.CalendarId);

            modelBuilder.Entity<Users>().HasKey(a => a.UserId);

            modelBuilder.Entity<Appointments>().HasOne(a => a.UserInfo)
                        .WithMany()
                        .HasForeignKey(a => a.UserId);
            modelBuilder.Entity<Appointments>().HasOne(a => a.Calendar)
                        .WithMany()
                        .HasForeignKey(a => a.CalendarCode);

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Calendars> Calendars { get; set; }

    }
}
