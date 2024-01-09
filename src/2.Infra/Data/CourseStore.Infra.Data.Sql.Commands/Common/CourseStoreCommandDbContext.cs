using CourseStore.Core.Domain.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace CourseStore.Infra.Data.Sql.Commands.Common;

public class CourseStoreCommandDbContext : BaseOutboxCommandDbContext
{
    #region DbSets
    public DbSet<Teacher> Teachers{ get; set; }
    #endregion
    public CourseStoreCommandDbContext(DbContextOptions<CourseStoreCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}