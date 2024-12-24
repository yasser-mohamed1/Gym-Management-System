namespace GymManagement.Infrastructure.Common.Persistence;

using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using Microsoft.EntityFrameworkCore;

public class GymManagementDbContext : DbContext, IUnitOfWork
{
    public GymManagementDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Subscription> Subscriptions { get; set; } = null!;

    public async Task CommitChangesAsync()
    {
        await SaveChangesAsync();
    }
}
