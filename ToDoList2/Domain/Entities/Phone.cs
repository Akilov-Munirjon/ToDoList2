using ToDoList2.Domain.Common.BaseEntities;

namespace ToDoList2.Domain.Entities.Models
{
    public class Phone : BaseEntity
    {
        public string Name { get; set; }
        
        public Guid BatteryId { get; set; }
        public Battery Battery { get; set; }

        public Guid BrandId { get; set; }
        public Guid DisplayId { get; set; }
        public Guid CpuId { get; set; }
        public Guid MemoryId { get; set; }
        public Guid CameraId { get; set; }
        public Guid CameraTypeId { get; set; }
        public Guid DisplayQualityId { get; set; }
        public Guid СonnectorId { get; set; }
        public Guid SimTypeId { get; set; }
        
        public Guid OsId { get; set; }
        public Os Os { get; set; }
        
        public Guid ConnectorId { get; set; }
        public Guid PhoneConnectorId { get; set; }
    }
}
