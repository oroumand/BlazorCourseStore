using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.RenameTeachers
{
    public class RenameCourseCommand : ICommand
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        

    }
}
