using ToDoList2.Domain.Common.BaseEntities;

namespace ToDoList2.Domain.Entities
{
    public class PhoneConnector : BaseEntity
    {
        public Guid PhoneId { get; set; }
        public Guid ConnectorId { get; set; }
    }
}
