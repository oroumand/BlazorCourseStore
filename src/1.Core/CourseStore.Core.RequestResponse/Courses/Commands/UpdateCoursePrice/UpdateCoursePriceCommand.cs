using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Courses.Commands.UpdateCoursePrice
{
    public class UpdateCoursePriceCommand : ICommand
    {
        public int CourseId { get; set; }
        public long Price { get; set; }
    }
}
