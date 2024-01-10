using AutoMapper;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Commands.UpdateDescription;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateDescription
{
    public class UpdateDescriptionProfile : Profile
    {
        public UpdateDescriptionProfile()
        {
            CreateMap<UpdateDescriptionCommand, UpdateDescriptionParameter>().ReverseMap();
        }
    }

}
