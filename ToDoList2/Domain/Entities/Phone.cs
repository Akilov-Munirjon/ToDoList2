using ToDoList2.Domain.Common.BaseEntities;

namespace ToDoList2.Domain.Entities.Models
{
    public class Phone : BaseEntity
    {
        public string Name { get; set; }

        public Guid BatteryId { get; set; }
        public Battery Battery { get; set; }

        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }

        public Guid DisplayId { get; set; }
        public Display Display { get; set; }

        public Guid CpuId { get; set; }
        public Cpu Cpu { get; set; }

        public Guid MemoryId { get; set; }
        public Memory Memory { get; set; }

        public Guid CameraId { get; set; }
        public Camera Camera { get; set; }

        public Guid SimTypeId { get; set; }
        public SimType SimType { get; set; }

        
        public Guid OsId { get; set; }

        public Os Os { get; set; }

        public ICollection<PhoneConnector> PhoneConnector { get; set; } = new List<PhoneConnector>();

    }
}
