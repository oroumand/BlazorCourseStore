using Zamin.Core.RequestResponse.Commands;

namespace CourseStore.Core.RequestResponse.Teachers.Command
{
    public record CreateTeacherCommand(string FirstName,string LastName,string Description, string ImageUrl): ICommand<int>;

}
