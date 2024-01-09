using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Teachers.Events
{
    public sealed record TeacherRenamed(Guid BusinessId, string FirstName,string LastName) : IDomainEvent;
}
