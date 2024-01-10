using AutoMapper;
using CourseStore.Core.Domain.Courses.Parameters;
using CourseStore.Core.RequestResponse.Courses.Commands.UpdateCourseDescription;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateDescription
{
    public class UpdateCourseDescriptionProfile : Profile
    {
        public UpdateCourseDescriptionProfile()
        {
            CreateMap<UpdateCourseDescriptionCommand, UpdateDescriptionParameter>().ReverseMap();
        }
    }

}
