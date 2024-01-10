using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.UpdateImage
{
    public class UpdateCoursePriceCommand : ICommand
    {
        public int CourseId { get; set; }
        public long Price{ get; set; }
    }
}
