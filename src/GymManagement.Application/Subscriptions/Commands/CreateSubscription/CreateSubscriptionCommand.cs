namespace GymManagement.Application.Subscriptions.Commands;

using GymManagement.Domain;
using MediatR;

public record CreateSubscriptionCommand(
  string SubscriptionType,
  Guid AdminId) : IRequest<Result<Guid>>;