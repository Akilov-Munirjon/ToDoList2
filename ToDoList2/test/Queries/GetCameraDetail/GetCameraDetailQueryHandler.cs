using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ToDoList2.Infrastructure.Contexts;

namespace ToDoList2.test.Queries.GetCameraDetail
{
    public class GetCameraDetailQueryHandler : IRequestHandler<GetCameraDetailQuery, CameraDetail>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCameraDetailQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<CameraDetail> Handle(GetCameraDetailQuery request, CancellationToken cancellationToken)
        {
            var camera = await _dbContext.Cameras
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            var cameraDetail = _mapper.Map<CameraDetail>(camera);

            return cameraDetail;
        }
    }
}

