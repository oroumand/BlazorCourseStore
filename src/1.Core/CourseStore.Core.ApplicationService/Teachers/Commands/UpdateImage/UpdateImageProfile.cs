using AutoMapper;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Commands.UpdateImage;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateImage
{
    public class UpdateImageProfile : Profile
    {
        public UpdateImageProfile()
        {
            CreateMap<UpdateImageCommand, UpdateImageParameter>().ReverseMap();
        }
    }

}
