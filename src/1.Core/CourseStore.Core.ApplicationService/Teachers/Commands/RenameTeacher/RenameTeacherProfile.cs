using AutoMapper;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Command.RenameTeachers;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.CreateTeacher
{
    public class RenameTeacherProfile : Profile
    {
        public RenameTeacherProfile()
        {
            CreateMap<RenameTeacherCommand, RenameParameter>().ReverseMap();
        }
    }

}
