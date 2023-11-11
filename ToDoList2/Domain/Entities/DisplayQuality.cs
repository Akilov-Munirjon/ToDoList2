using ToDoList2.Domain.Common.BaseEntities;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Domain.Entities
{
    public class DisplayQuality : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Display> Displayes { get; set; } = new List<Display>(); 
    }
}