using FluentValidation;
using ToDoList2.Cqrs;

namespace ToDoList2.Cqrs_пример
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(command => command.Username)
                .NotEmpty()
                .WithMessage("Имя пользователя не может быть пустым или нулевым.");

            RuleFor(command => command.Email)
                .NotEmpty()
                .WithMessage("Адрес электронной почты не может быть пустым или нулевым.")
                .EmailAddress()
                .WithMessage("Некорректный формат адреса электронной почты.");

            RuleFor(command => command.Password)
                .NotEmpty()
                .WithMessage("Пароль не может быть пустым или нулевым");
        }
    }
}
