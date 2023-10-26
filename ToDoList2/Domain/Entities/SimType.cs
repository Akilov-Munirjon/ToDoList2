using ToDoList2.Domain.Common.BaseEntities;

namespace ToDoList2.Domain.Entities.Models
{
    public class Simtype : BaseEntity
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
