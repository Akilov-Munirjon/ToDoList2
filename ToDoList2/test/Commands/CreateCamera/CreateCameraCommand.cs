using MediatR;

namespace ToDoList2.test
{
    public class CreateCameraCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid CameraTypeId { get; set; }
    }
}
