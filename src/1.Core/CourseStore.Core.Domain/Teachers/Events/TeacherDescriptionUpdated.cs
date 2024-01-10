using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Teachers.Events
{
    public sealed record TeacherDescriptionUpdated(Guid BusinessId,string Description) : IDomainEvent;
}
