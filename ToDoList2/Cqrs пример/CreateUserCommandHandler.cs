using FluentValidation;
using System.Data.Entity;
using ToDoList2.Cqrs;

namespace ToDoList2.Cqrs.CreatUserCommandHandler
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(command => command.Username)
                .NotEmpty().WithMessage("Имя пользователя не может быть пустым или нулевым.");

            RuleFor(command => command.Email)
                .NotEmpty().WithMessage("Адрес электронной почты не может быть пустым или нулевым.")
                .EmailAddress().WithMessage("Некорректный формат адреса электронной почты.");

            RuleFor(command => command.Password)
                .NotEmpty().WithMessage("Пароль не может быть пустым или нулевым");
        }
    }

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

