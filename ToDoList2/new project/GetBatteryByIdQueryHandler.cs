using AutoMapper;
using MediatR;
using System.Data.Entity;
using ToDoList2.Infrastructure.Contexts;

namespace ToDoList2.new_project
{
    public class GetBatteryByIdQueryHandler : IRequestHandler<GetBatteryByIdQuery, BatteryDto>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetBatteryByIdQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<BatteryDto> Handle(GetBatteryByIdQuery request, CancellationToken cancellationToken)
        {
            var battery = await _dbContext.Batteries
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            var batteryDto = _mapper.Map<BatteryDto>(battery);

            return batteryDto;
        }
    }
}


