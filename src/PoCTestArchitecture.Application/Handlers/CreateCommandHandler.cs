using PoCTestArchitecture.Application.Handlers.Request;
using PoCTestArchitecture.Application.Handlers.Response;
using PoCTestArchitecture.Domain.Entities;
using PoCTestArchitecture.Domain.Repositories;

namespace PoCTestArchitecture.Application.Handlers;
public class CreateCommandHandler : ICommandHandler<CreateUserRequest, CreateUserResponse>
{
    private readonly IUserRepository _repository;

    public async Task<CreateUserResponse> Execute(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var user = new User(request.FirstName, request.LastName);
        
        user = await _repository.InsertAsync(user);

        return new CreateUserResponse(user.Id);
    }
}
