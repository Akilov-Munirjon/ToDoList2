using FluentValidation;
using MediatR;

namespace ToDoList2.test.Command.CreateCamera
{
    public class CreateCameraCommandValidator : AbstractValidator<CreateCameraCommand>
    {
        public CreateCameraCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Type)
                .NotEmpty();

            RuleFor(x => x.Type)
                .NotEmpty()
                .MaximumLength(50);


            RuleFor(x => x.CameraTypeId)
                .NotEmpty()
                .WithMessage("message");

        }

    }
}
