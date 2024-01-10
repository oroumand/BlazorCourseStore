using CourseStore.Core.Domain.Courses.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace CourseStore.Core.Contracts.Courses.Commands
{
    public interface ICourseCommandRepository : ICommandRepository<Course, int>
    {
    }
}
