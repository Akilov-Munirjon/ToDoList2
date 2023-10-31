using ToDoList2.Domain.Common.BaseEntities;

namespace ToDoList2.Domain.Entities.Models
{
    public class Battery : BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public ICollection<Phone> Phones { get; set; } = new List<Phone>();
       
    }
}
