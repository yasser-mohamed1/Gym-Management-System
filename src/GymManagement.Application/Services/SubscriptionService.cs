namespace GymManagement.Application.Services;

public class SubscriptionService : ISubscriptionService
{
    Guid ISubscriptionService.CreateSubscription(string SubscriptionType, Guid adminId)
    {
        return Guid.NewGuid();
    }
}