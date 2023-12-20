using AutoMapper;

namespace ToDoList2.test.Mapping
{
    public class CameraMaping
    {
        public class CameraMappingProfile : Profile
        {
            public CameraMappingProfile()
            {
                CreateMap<Camera, CameraDto>();
            }
        }
    }
}
