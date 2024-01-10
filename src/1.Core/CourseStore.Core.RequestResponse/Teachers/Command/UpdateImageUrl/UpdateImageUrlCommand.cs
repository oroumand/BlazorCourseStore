using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Command.UpdateImageUrl
{
    public class UpdateImageUrlCommand : ICommand
    {
        public int TeacherId { get; set; }
        public string ImageUrl { get; set; }
    }
}
