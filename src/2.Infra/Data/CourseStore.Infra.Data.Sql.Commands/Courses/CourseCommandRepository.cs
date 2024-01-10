using CourseStore.Core.Contracts.Courses.Commands;
using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace CourseStore.Infra.Data.Sql.Commands.Teachers
{
    public sealed class CourseCommandRepository(CourseStoreCommandDbContext dbContext) : BaseCommandRepository<Course, CourseStoreCommandDbContext, int>(dbContext), ICourseCommandRepository
    {
    }
}
