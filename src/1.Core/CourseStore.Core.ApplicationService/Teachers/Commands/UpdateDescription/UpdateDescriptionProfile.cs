using AutoMapper;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Command.UpdateDescription;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.CreateTeacher
{
    public class UpdateDescriptionProfile : Profile
    {
        public UpdateDescriptionProfile()
        {
            CreateMap<UpdateDescriptionCommand, UpdateDescriptionParameter>().ReverseMap();
        }
    }

}
