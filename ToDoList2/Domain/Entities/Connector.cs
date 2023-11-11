using ToDoList2.Domain.Common.BaseEntities;

namespace ToDoList2.Domain.Entities.Models
{
    public class Connector : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<PhoneConnector> PhoneConnector { get; set; } = new List<PhoneConnector>();
    } 
}
