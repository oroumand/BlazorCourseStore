using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CourseStore.Infra.Data.Sql.Commands.Common;

public class CourseStoreCommandDbContextFactory : IDesignTimeDbContextFactory<CourseStoreCommandDbContext>
{
    public CourseStoreCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<CourseStoreCommandDbContext>();

        builder.UseSqlServer("Server =10.100.7.202,1433; Database=CourseStoreDb;User Id = sa;Password=55MS@B1M3gary; MultipleActiveResultSets=true; Encrypt = false");

        return new CourseStoreCommandDbContext(builder.Options);
    }
}