namespace GymManagement.Application.Interfaces;

using GymManagement.Domain.Subscriptions;

public interface ISubscriptionRepository
{
    Task AddSubscriptionAsync(Subscription subscription);
    Task<Subscription?> GetByIdAsync(Guid subscriptionId);
}