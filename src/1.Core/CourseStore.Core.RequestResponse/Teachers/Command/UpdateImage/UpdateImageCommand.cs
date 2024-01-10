using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Command.UpdateImageUrl
{
    public class UpdateImageCommand : ICommand
    {
        public int TeacherId { get; set; }
        public string ImageUrl { get; set; }
    }
}
