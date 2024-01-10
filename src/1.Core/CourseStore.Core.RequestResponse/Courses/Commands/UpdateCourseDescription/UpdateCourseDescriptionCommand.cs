using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.UpdateDescription
{
    public class UpdateCourseDescriptionCommand : ICommand
    {
        public int CourseId { get; set; }
        public string Description { get; set; }

    }
}
