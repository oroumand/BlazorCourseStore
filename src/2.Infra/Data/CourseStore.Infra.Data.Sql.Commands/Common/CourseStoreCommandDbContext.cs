using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Core.Domain.Toolkits.ValueObjects;
using Zamin.Core.Domain.ValueObjects;
using Zamin.Extensions.Events.Outbox.Dal.EF;
using Zamin.Infra.Data.Sql.Commands.ValueConversions;

namespace CourseStore.Infra.Data.Sql.Commands.Common;

public class CourseStoreCommandDbContext : BaseOutboxCommandDbContext
{
    #region DbSets
    public DbSet<Teacher> Teachers{ get; set; }
    public DbSet<Course> Courses { get; set; }
    #endregion
    public CourseStoreCommandDbContext(DbContextOptions<CourseStoreCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<BusinessId>().HaveConversion<BusinessIdConversion>();
        configurationBuilder.Properties<Title>().HaveConversion<TitleConversion>();
        configurationBuilder.Properties<Description>().HaveConversion<DescriptionConversion>();
        configurationBuilder.Properties<NationalCode>().HaveConversion<NationalCodeConversion>();
    }
}