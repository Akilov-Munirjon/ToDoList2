using ToDoList2.Domain.Common.BaseEntities;

namespace ToDoList2.Domain.Entities.Models
{
    public class Os : BaseEntity
    {
        public string Name { get; set; }
        public int Version { get; set; }

        public ICollection<Phone> Phones { get; set; } = new List<Phone>();

        
    }
}
