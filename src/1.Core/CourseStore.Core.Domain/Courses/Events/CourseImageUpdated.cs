using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Courses.Events;
public sealed record CourseImageUpdated(Guid BusinessId, string ImageUrl) : IDomainEvent;