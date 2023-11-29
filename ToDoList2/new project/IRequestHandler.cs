using MediatR;
using static ToDoList2.new_project.Query;
using ToDoList2.Domain.Entities.Models;
using Amazon;
using AutoMapper;
using Profile = AutoMapper.Profile;

namespace ToDoList2.new_project
{
    public class IRequestHandler
    {
        private readonly IBatteryRepository _batteryRepository;
        private readonly IMapper _mapper;

        public GetBatteryByIdQueryHandler(IBatteryRepository batteryRepository, IMapper mapper)
        {
            _batteryRepository = batteryRepository;
            _mapper = mapper;
        }

        public async Task<BatteryDto> Handle(GetBatteryByIdQuery request, CancellationToken cancellationToken)
        {
            var battery = await _batteryRepository.GetById(request.Id);
            return _mapper.Map<BatteryDto>(battery);
        }

        public class BatteryMappingProfile : Profile
        {
            public BatteryMappingProfile()
            {
                CreateMap<Battery, BatteryDto>();
            }
        }



    }
}
