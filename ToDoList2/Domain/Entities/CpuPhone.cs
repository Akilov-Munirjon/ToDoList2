using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.Domain.Entities
{
    public class CpuPhone
    {
        public Guid Id { get; set; }

        public Guid CpuId { get; set; }
        public Cpu Cpu { get; set; }

        public Guid PhoneId { get; set; }
        public Phone Phone { get; set; }

    }
}
