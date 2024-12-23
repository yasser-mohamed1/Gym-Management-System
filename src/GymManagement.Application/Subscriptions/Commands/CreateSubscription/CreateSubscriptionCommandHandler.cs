namespace GymManagement.Application.Subscriptions.Commands;

using GymManagement.Domain;
using MediatR;

public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, Result<Guid>>
{
    public async Task<Result<Guid>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
    {
        return Result<Guid>.Success(Guid.NewGuid());
    }
}