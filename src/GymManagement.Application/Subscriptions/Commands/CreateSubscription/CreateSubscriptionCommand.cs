namespace GymManagement.Application.Subscriptions.Commands;

using MediatR;

public record CreateSubscriptionCommand(
  string SubscriptionType,
  Guid AdminId) : IRequest<Guid>;