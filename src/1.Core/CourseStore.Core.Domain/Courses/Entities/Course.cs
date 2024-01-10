using CourseStore.Core.Domain.Courses.Events;
using CourseStore.Core.Domain.Courses.Parameters;
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


        #region Constructors
        private Course()
        {

        }
        public Course(CreateParameter command)
        {
            Title = command.Title;
            Price = command.Price;
            Description = command.Description;
            ImageUrl = command.ImageUrl;
            AddEvent(new CourseCreated(BusinessId.Value, Title.Value, Description.Value, ImageUrl,Price.Value));
        }
        #endregion

        #region Commands

        public void Handle(RenameParameter command)
        {
            Title = command.Title;
            AddEvent(new CourseRenamed(BusinessId.Value, Title.Value));
        }

        public void Handle(UpdateDescriptionParameter command)
        {
            Description = command.Description;
            AddEvent(new CourseDescriptionUpdated(BusinessId.Value, Description.Value));
        }
        public void Handle(UpdateImageParameter command)
        {
            ImageUrl = command.ImageUrl;
            AddEvent(new CourseImageUpdated(BusinessId.Value, ImageUrl));
        }

        public void Handle(UpdatePriceParameter command)
        {
            Price = command.Price;
            AddEvent(new CoursePriceUpdated(BusinessId.Value, Price.Value));
        }
        #endregion
    }
}
