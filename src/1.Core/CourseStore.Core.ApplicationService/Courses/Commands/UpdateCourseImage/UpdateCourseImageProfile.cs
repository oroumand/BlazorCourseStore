using AutoMapper;
using CourseStore.Core.Domain.Courses.Parameters;
using CourseStore.Core.RequestResponse.Courses.Commands.UpdateCourseImage;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateImage
{
    public class UpdateCourseImageProfile : Profile
    {
        public UpdateCourseImageProfile()
        {
            CreateMap<UpdateCourseImageCommand, UpdateImageParameter>().ReverseMap();
        }
    }

}
