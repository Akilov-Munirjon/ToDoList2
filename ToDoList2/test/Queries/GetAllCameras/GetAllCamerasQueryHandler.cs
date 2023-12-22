using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ToDoList2.Domain.Entities.Models;
using ToDoList2.Infrastructure.Contexts;

namespace ToDoList2.test.Queries.GetAllCameras
{
    public class GetAllCamerasQueryHandler : IRequestHandler<GetAllCamerasQuery, List<Camera>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllCamerasQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Camera>> Handle(GetAllCamerasQuery request, CancellationToken cancellationToken)
        {
            var cameras = await _dbContext.Cameras.ToListAsync(cancellationToken);
            return _mapper.Map<List<Camera>>(cameras);
        }
    }
}