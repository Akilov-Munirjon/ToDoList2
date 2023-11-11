using ToDoList2.Domain.Common.BaseEntities;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Domain.Entities
{
    public class CameraType : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Camera> Camera { get; set; } = new List<Camera>(); 
    }
}
