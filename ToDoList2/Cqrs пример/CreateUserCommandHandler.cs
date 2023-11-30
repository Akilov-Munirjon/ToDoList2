using FluentValidation;
using System.Data.Entity;
using ToDoList2.Cqrs;
using ToDoList2.Cqrs_пример;

namespace ToDoList2.Cqrs.CreatUserCommandHandler
{
    public class CreateUserCommandHandler
    {
        private readonly DbContext _dbContext;

        public CreateUserCommandHandler(DbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Handle(CreateUserCommand command)
        {
            var validator = new CreateUserCommandValidator();
            var validationResult = validator.Validate(command);

            if (!validationResult.IsValid)
            {
                Console.WriteLine("Проверка не удалась:");
                foreach (var error in validationResult.Errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
                return;
            }

            Console.WriteLine("Пользователь успешно создан!");
            
        }
    }
}

