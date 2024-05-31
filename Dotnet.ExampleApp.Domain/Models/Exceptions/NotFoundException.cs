namespace Dotnet.ExampleApp.Domain.Models.Exceptions
{
    public class NotFoundException : SystemException
    {
        public NotFoundException() { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}
