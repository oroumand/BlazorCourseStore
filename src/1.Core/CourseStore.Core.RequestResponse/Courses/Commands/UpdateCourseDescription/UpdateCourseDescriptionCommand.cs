using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Courses.Commands.UpdateCourseDescription
{
    public class UpdateCourseDescriptionCommand : ICommand
    {
        public int CourseId { get; set; }
        public string Description { get; set; }

    }
}
