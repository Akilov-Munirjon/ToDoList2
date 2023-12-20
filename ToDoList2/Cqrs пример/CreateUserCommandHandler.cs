using MediatR;
using ToDoList2.Cqrs_пример;
using ToDoList2.Infrastructure.Contexts;

namespace ToDoList2.Cqrs.CreatUserCommandHandler
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;

        public CreateUserCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateUserCommandValidator();
            var validationResult = validator.Validate(request);

            if (!validationResult.IsValid)
            {
                Console.WriteLine("Проверка не удалась:");
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

           return Task.FromResult(Guid.Empty);
        }
    }
}

