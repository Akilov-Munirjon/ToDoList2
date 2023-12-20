using MediatR;

namespace ToDoList2.test
{
    public class GetCameraByIdQuery : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
