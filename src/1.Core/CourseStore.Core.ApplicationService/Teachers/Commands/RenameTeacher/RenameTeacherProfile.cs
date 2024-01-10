using AutoMapper;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Commands.RenameTeachers;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.RenameTeacher
{
    public class RenameTeacherProfile : Profile
    {
        public RenameTeacherProfile()
        {
            CreateMap<RenameTeacherCommand, RenameParameter>().ReverseMap();
        }
    }

}
