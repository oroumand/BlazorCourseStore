using AutoMapper;
using CourseStore.Core.Domain.Courses.Parameters;
using CourseStore.Core.RequestResponse.Courses.Commands.UpdateCoursePrice;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateImage
{
    public class UpdateCoursePriceProfile : Profile
    {
        public UpdateCoursePriceProfile()
        {
            CreateMap<UpdateCoursePriceCommand, UpdatePriceParameter>().ReverseMap();
        }
    }

}
