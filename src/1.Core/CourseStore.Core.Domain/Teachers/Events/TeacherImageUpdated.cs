using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Teachers.Events
{
    public sealed record TeacherImageUpdated(Guid BusinessId, string ImageUrl) : IDomainEvent;
}
