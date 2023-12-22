using MediatR;

namespace ToDoList2.test
{
    public class GetCameraDetailQuery : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
