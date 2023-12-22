using MediatR;

namespace ToDoList2.test
{
    public class GetAllCamerasQuery : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
