using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.UpdateImage
{
    public class UpdateImageCommand : ICommand
    {
        public int TeacherId { get; set; }
        public string ImageUrl { get; set; }
    }
}
