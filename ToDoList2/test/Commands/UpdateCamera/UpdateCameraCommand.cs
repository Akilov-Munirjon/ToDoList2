using MediatR;

namespace ToDoList2.test
{
    public class UpdateCameraCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
       
    }
}
