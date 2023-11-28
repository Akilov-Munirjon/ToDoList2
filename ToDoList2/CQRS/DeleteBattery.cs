using MediatR;

namespace ToDoList2.CQRS
{
    public class DeleteBatteryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
