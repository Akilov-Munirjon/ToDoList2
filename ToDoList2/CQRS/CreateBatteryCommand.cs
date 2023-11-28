using MediatR;

namespace ToDoList2.CQRS
{
        public class CreateBatteryCommand : IRequest<Guid>
        {
            public string Name { get; set; }
            public int Capacity { get; set; }
        }
}
