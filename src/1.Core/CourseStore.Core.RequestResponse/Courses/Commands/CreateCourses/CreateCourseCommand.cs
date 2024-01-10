using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Courses.Commands.CreateCourses
{
    public class CreateCourseCommand : ICommand<int>
    {
        public string Title { get; set; }
        public long Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int TeacherId { get; set; }
    }
}
