using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace CourseStore.Infra.Data.Sql.Queries.Common;

public class CourseStoreQueryDbContext : BaseQueryDbContext
{
    public CourseStoreQueryDbContext(DbContextOptions<CourseStoreQueryDbContext> options) : base(options)
    {
    }
}