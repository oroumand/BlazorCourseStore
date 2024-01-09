using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Teachers.Events
{
    public sealed record TeacherImageChanged(Guid BusinessId, string ImageUrl) : IDomainEvent;
}
