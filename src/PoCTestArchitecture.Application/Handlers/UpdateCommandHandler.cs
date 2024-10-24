using PoCTestArchitecture.Application.Handlers.Request;
using PoCTestArchitecture.Application.Handlers.Response;

namespace PoCTestArchitecture.Application.Handlers
{
    public class UpdateCommandHandler : ICommandHandler<CreateUserRequest, CreateUserResponse>
    {
        public Task<CreateUserResponse> Execute(CreateUserRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
