using AutoMapper;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Command.UpdateDescription;
using CourseStore.Core.RequestResponse.Teachers.Command.UpdateImageUrl;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.CreateTeacher
{
    public class UpdateImageProfile : Profile
    {
        public UpdateImageProfile()
        {
            CreateMap<UpdateImageCommand, UpdateImageParameter>().ReverseMap();
        }
    }

}
