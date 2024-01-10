using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.RenameTeachers
{
    public class RenameTeacherCommand : ICommand
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
