using AutoMapper;
using ToDoList2.Domain.Entities.Models;
using ToDoList2.test.Queries.GetCameraDetail;

namespace ToDoList2.test.Mapping
{
    public class CameraMaping
    {
        public class CameraMappingProfile : Profile
        {
            public CameraMappingProfile()
            {
                CreateMap<Camera, Camera>();
                CreateMap<GetCameraDetailQueryHandler, GetCameraDetailQueryHandler>();
            }
        }
    }
}
