using MediatR;
using ToDoList2.test.Command.CreateCamera;

namespace ToDoList2.test
{
    public class CreateCameraCommand : IRequest<Guid>
    {
        public Guid CameraTypeId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        
    }
}
