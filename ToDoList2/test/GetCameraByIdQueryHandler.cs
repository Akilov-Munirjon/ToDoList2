using AutoMapper;
using MediatR;
using ToDoList2.Infrastructure.Contexts;

namespace ToDoList2.test
{
    public class GetCameraByIdQueryHandler : IRequestHandler<GetCameraByIdQuery, CameraDto>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCameraByIdQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CameraDto> Handle(GetCameraByIdQuery request, CancellationToken cancellationToken)
        {
            var camera = _dbContext.Cameras.Where(c => c.Id == request.Id).FirstOrDefault();
            return _mapper.Map<CameraDto>(camera);
        }
    }
}
