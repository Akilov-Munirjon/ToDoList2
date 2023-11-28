namespace ToDoList2.Cqrs
{
    public class Validations
    {
        class Program
        {
            static void Main()
            {
                var command = new CreateUserCommand
                {
                    Username = "Tom",
                    Email = "tom@gmaol.com",
                    Password = "1234"
                };

                var handler = new CreateUserCommandHandler();

                try
                {
                    handler.Handle(command);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Validation error: {ex.Message}");
                }
            }
        }
    }
}
