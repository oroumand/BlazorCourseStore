using CourseStore.Core.Domain.Courses.ValueObjects;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace CourseStore.Core.Domain.Courses.Entities
{
    public class Course:AggregateRoot<int>
    {
        #region Properties
        public Title Title { get; private set; }
        public Description Description { get; private set; }
        public string ImageUrl { get; private set; }
        public Price Price { get; set; }
        public int TeacherId { get; set; }
        #endregion


    }
}
