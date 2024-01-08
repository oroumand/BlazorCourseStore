using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace CourseStore.Infra.Data.Sql.Commands.Common;

public class CourseStoreCommandDbContext : BaseOutboxCommandDbContext
{
    public CourseStoreCommandDbContext(DbContextOptions<CourseStoreCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}