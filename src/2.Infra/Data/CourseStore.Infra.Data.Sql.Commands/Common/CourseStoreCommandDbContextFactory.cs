using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CourseStore.Infra.Data.Sql.Commands.Common;

public class CourseStoreCommandDbContextFactory : IDesignTimeDbContextFactory<CourseStoreCommandDbContext>
{
    public CourseStoreCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<CourseStoreCommandDbContext>();

        builder.UseSqlServer("Server =.; Database=CourseStoreDb;User Id = ;Password = ; MultipleActiveResultSets = true; Encrypt = false");

        return new CourseStoreCommandDbContext(builder.Options);
    }
}