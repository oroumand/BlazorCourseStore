using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.CreateTeachers
{
    public class CreateCourseCommand : ICommand<int>
    {
        public string Title { get; set; }
        public long Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
