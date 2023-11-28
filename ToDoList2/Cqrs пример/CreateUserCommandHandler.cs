namespace ToDoList2.Cqrs
{
    public class CreateUserCommandHandler
    {
        public void Handle(CreateUserCommand command)
        {
            
            if (string.IsNullOrWhiteSpace(command.Username))
            {
                throw new ArgumentException("Имя пользователя не может быть пустым или нулевым.");
            }

            if (string.IsNullOrWhiteSpace(command.Email))
            {
                throw new ArgumentException("Адрес электронной почты не может быть пустым или нулевым.");
            }

            if (string.IsNullOrWhiteSpace(command.Password))
            {
                throw new ArgumentException("Пароль не может быть пустым или нулевым");
            }

            Console.WriteLine("User created successfully!");
        }
    }
}
