namespace GymManagement.Infrastructure.Subscriptions.Persistence;

using System.Threading.Tasks;
using GymManagement.Application.Interfaces;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Persistence;

public class SubscriptionRepository : ISubscriptionRepository
{
  private readonly GymManagementDbContext _dbContext;

  public SubscriptionRepository(GymManagementDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public async Task AddSubscriptionAsync(Subscription subscription)
  {
    await _dbContext.Subscriptions.AddAsync(subscription);
  }

  public async Task<Subscription?> GetByIdAsync(Guid subscriptionId)
  {
    return await _dbContext.Subscriptions.FindAsync(subscriptionId);
  }
}