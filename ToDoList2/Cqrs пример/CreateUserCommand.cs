using MediatR;

namespace ToDoList2.Cqrs
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
