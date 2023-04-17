using AutoMapper;
using DataModels = AppointmentAPI.DataModels;
using DomainModels = AppointmentAPI.DomainModels;
namespace AppointmentAPI.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Appointments, DomainModels.Appointments>().ReverseMap();
            CreateMap<DataModels.Calendars, DomainModels.Calendars>().ReverseMap();
            CreateMap<DataModels.Users, DomainModels.Users>().ReverseMap();
        }

    }
}