namespace ToDoList2.new_project
{
    public class GetBatteryByIdQuery : IRequest<BatteryDto>
    {
        public Guid Id { get; set; }
    }

}
