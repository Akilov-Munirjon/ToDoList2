using AutoMapper;
using MediatR;
using ToDoList2.Infrastructure.Contexts;

namespace ToDoList2.test.Command.CreateCamera
{
    public class CreateCameraCommandHandler : IRequestHandler<CreateCameraCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateCameraCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task<Guid> Handle(CreateCameraCommand request, CancellationToken cancellationToken)
        {
            var camera = _mapper.Map<Camera>(request);

            _dbContext.Cameras.Add(camera);

            return Task.FromResult(Guid.Empty);
        }
    }
}


