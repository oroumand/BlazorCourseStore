using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Courses.Events;
public sealed record CourseCreated(Guid BusinessId, string Title, string Description, string ImageUrl, long Price) : IDomainEvent;
