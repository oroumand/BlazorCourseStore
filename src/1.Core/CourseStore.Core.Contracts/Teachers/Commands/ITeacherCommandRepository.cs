using CourseStore.Core.Domain.Teachers.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace CourseStore.Core.Contracts.Teachers.Commands
{
    public interface ITeacherCommandRepository:ICommandRepository<Teacher, int>
    {
    }
}
