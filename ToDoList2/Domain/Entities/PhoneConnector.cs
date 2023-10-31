using ToDoList2.Domain.Common.BaseEntities;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Domain.Entities
{
    public class PhoneConnector : BaseEntity
    {
        public Guid PhoneId { get; set; }
        public Guid ConnectorId { get; set; }

        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
    }
}
