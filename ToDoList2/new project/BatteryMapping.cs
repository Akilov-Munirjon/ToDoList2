using AutoMapper;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.new_project
{
    public class BatteryMappingProfile : Profile
    {
        public BatteryMappingProfile()
        {
            CreateMap<Battery, BatteryDto>();
        }
    }
}
