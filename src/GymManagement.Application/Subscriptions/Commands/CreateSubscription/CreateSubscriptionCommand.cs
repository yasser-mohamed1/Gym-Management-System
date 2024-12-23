namespace GymManagement.Application.Subscriptions.Commands;

using GymManagement.Domain;
using GymManagement.Domain.Subscriptions;
using MediatR;

public record CreateSubscriptionCommand(
  string SubscriptionType,
  Guid AdminId) : IRequest<Result<Subscription>>;