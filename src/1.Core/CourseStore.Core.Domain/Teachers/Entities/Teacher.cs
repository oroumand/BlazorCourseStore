using CourseStore.Core.Domain.Teachers.Events;
using CourseStore.Core.Domain.Teachers.Parameters;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace CourseStore.Core.Domain.Teachers.Entities
{
    public class Teacher : AggregateRoot<int>
    {
        #region Properties
        public Title FirstName { get; private set; }
        public Title LastName { get; private set; }
        public Description Description { get; private set; }
        public string ImageUrl { get; private set; }
        #endregion

        #region Constructors
        private Teacher()
        {

        }
        public Teacher(CreateParameter command)
        {
            FirstName = command.FirstName;
            LastName = command.LastName;
            Description = command.Description;
            ImageUrl = command.ImageUrl;
            AddEvent(new TeacherCreated(BusinessId.Value, FirstName.Value, LastName.Value, Description.Value, ImageUrl));
        }
        #endregion

        #region Commands

        public void Handle(RenameParameter command)
        {
            FirstName = command.FirstName;
            LastName = command.LastName;
            AddEvent(new TeacherRenamed(BusinessId.Value, FirstName.Value, LastName.Value));
        }

        public void Handle(UpdateDescriptionParameter command)
        {
            Description = command.Description;
            AddEvent(new TeacherDescriptionUpdated(BusinessId.Value, Description.Value));
        }
        public void Handle(UpdateImageParameter command)
        {
            ImageUrl = command.ImageUrl;
            AddEvent(new TeacherImageUpdated(BusinessId.Value, ImageUrl));
        }
        #endregion

    }
}
