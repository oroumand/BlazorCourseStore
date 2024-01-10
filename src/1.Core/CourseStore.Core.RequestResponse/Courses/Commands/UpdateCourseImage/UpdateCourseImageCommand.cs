using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.UpdateImage
{
    public class UpdateCourseImageCommand : ICommand
    {
        public int CourseId { get; set; }
        public string ImageUrl { get; set; }
    }
}
