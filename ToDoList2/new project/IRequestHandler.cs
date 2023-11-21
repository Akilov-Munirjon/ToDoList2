using MediatR;
using static ToDoList2.new_project.Query;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.new_project
{
    public class IRequestHandler
    {
        public class GetBatteryByIdQueryHandler : IRequestHandler<GetBatteryByIdQuery, BatteryDto>
        {
            private readonly IBatteryRepository _batteryRepository;

            public GetBatteryByIdQueryHandler(IBatteryRepository batteryRepository)
            {
                _batteryRepository = batteryRepository;
            }

            public async Task<BatteryDto> Handle(GetBatteryByIdQuery request, CancellationToken cancellationToken)
            {
                var battery = await _batteryRepository.GetById(request.Id);
                return MapToDto(battery);
            }

            private BatteryDto MapToDto(Battery battery)
            {
                return new BatteryDto
                {
                    Id = battery.Id,
                    Name = battery.Name,
                    Capacity = battery.Capacity
                };
            }
        }
    }
}
