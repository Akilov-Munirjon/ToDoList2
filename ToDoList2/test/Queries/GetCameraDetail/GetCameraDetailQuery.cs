using MediatR;
using ToDoList2.test.Queries.GetCameraDetail;

namespace ToDoList2.test
{
    public class GetCameraDetailQuery : IRequest<CameraDetail>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
