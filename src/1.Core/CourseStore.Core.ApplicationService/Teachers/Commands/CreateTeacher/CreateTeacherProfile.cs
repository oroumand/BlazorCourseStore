using AutoMapper;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Command.CreateTeachers;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.CreateTeacher
{
    public class CreateTeacherProfile : Profile
    {
        public CreateTeacherProfile()
        {
            CreateMap<CreateTeacherCommand, CreateParameter>().ReverseMap();
        }
    }

}
