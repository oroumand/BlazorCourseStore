using CourseStore.Infra.Data.Sql.Queries.Teachers.Entities;
using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace CourseStore.Infra.Data.Sql.Queries.Common;

public class CourseStoreQueryDbContext : BaseQueryDbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public CourseStoreQueryDbContext(DbContextOptions<CourseStoreQueryDbContext> options) : base(options)
    {
    }
}