using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Courses.Commands.RenameCourses
{
    public class RenameCourseCommand : ICommand
    {
        public int CourseId { get; set; }
        public string Title { get; set; }


    }
}
