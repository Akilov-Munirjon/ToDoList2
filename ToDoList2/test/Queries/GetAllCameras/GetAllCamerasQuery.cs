using MediatR;
using ToDoList2.Domain.Entities.Models;

namespace ToDoList2.test
{
    public class GetAllCamerasQuery : IRequest<List<Camera>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
