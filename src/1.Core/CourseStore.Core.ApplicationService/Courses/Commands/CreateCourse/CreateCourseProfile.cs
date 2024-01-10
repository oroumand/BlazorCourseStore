using AutoMapper;
using CourseStore.Core.Domain.Courses.Parameters;
using CourseStore.Core.RequestResponse.Courses.Commands.CreateCourses;

namespace CourseStore.Core.ApplicationService.Courses.Commands.CreateCourse
{
    public class CreateCourseProfile : Profile
    {
        public CreateCourseProfile()
        {
            CreateMap<CreateCourseCommand, CreateParameter>().ReverseMap();
        }
    }

}
