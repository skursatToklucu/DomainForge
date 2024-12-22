namespace DomainForgeFramework.Application.Interfaces
{
    /// <summary>
    /// Represents a command that can be executed by the application.
    /// Commands are used to encapsulate the input data required to perform an action in the application.
    /// </summary>
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        // Executes the command.
        Task HandleAsync(TCommand command);
    }
}