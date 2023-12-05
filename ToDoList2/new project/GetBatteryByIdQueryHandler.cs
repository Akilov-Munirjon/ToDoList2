using ToDoList2.Domain.Entities.Models;
using AutoMapper;
using Profile = AutoMapper.Profile;
using MediatR;
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
            var battery = _dbContext.Batteries.Where(b => b.Id == request.Id).FirstOrDefault();
            return _mapper.Map<BatteryDto>(battery);
        }
    }
}
