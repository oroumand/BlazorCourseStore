using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Courses.Events;
public sealed record CourseDescriptionUpdated(Guid BusinessId, string Description) : IDomainEvent;