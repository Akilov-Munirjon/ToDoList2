using MediatR;

namespace ToDoList2.CQRS
{
    public class UpdateBatteryCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
