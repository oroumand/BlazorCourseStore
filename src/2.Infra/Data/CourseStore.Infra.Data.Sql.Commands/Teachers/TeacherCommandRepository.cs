using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.Domain.Teachers.Entities;
using CourseStore.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace CourseStore.Infra.Data.Sql.Commands.Teachers
{
    public sealed class TeacherCommandRepository : BaseCommandRepository<Teacher, CourseStoreCommandDbContext, int>, ITeacherCommandRepository
    {
        public TeacherCommandRepository(CourseStoreCommandDbContext dbContext) : base(dbContext)
        {
        }
    }
}
