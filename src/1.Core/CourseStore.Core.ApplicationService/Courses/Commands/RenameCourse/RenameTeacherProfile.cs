using AutoMapper;
using CourseStore.Core.Domain.Courses.Parameters;
using CourseStore.Core.RequestResponse.Courses.Commands.RenameCourses;

namespace CourseStore.Core.ApplicationService.Courses.Commands.RenameCourse
{
    public class RenameCourseProfile : Profile
    {
        public RenameCourseProfile()
        {
            CreateMap<RenameCourseCommand, RenameParameter>().ReverseMap();
        }
    }

}
