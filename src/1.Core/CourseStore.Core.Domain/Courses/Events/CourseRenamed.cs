using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Courses.Events
{
    public sealed record CourseRenamed(Guid BusinessId, string Title) : IDomainEvent;
}
