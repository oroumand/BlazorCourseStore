using Zamin.Core.Domain.Events;

namespace CourseStore.Core.Domain.Teachers.Events
{
    public sealed record TeacherCreated(Guid BusinessId,string firstName,string LastName, string Description, string ImageUrl):IDomainEvent;
}
