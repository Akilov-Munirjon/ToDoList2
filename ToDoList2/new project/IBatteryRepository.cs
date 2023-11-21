using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.new_project
{
    public interface IBatteryRepository
    {
        Task<Battery> GetById(Guid id);
    }
}