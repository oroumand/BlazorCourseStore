using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Courses.Events;
public sealed record CoursePriceUpdated(Guid BusinessId, long Price) : IDomainEvent;
