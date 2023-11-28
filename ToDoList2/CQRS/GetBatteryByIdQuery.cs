using ToDoList2.new_project;

namespace ToDoList2.CQRS
{
    public class GetBatteryByIdQuery : IRequest<BatteryDto>
    {
        public Guid Id { get; set; }
    }
}
