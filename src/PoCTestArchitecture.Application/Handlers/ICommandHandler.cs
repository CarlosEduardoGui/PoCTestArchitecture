namespace PoCTestArchitecture.Application.Handlers;
public interface ICommandHandler<TRequest, TResponse>
{
    Task<TResponse> Execute(TRequest request, CancellationToken cancellationToken);
}
