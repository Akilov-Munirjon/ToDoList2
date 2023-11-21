namespace ToDoList2.new_project
{
    public class Query
    {
        public class GetBatteryByIdQuery : IRequest<BatteryDto>
        {
            public Guid Id { get; set; }
        }
    }
}
