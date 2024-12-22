namespace GymManagement.Application.Services;

public interface ISubscriptionWriteService
{
  Guid CreateSubscription(string SubscriptionType, Guid adminId);
}