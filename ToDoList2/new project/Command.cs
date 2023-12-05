using MediatR;

namespace ToDoList2.new_project
{
    public class CreateBatteryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
    }

}
