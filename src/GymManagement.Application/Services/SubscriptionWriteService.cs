namespace GymManagement.Application.Services;

public class SubscriptionWriteService : ISubscriptionWriteService
{
    Guid ISubscriptionWriteService.CreateSubscription(string SubscriptionType, Guid adminId)
    {
        return Guid.NewGuid();
    }
}