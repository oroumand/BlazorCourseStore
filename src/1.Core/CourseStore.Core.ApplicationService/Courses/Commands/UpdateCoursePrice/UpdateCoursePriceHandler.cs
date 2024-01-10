using CourseStore.Core.Contracts.Courses.Commands;
using CourseStore.Core.Domain.Courses.Parameters;
using CourseStore.Core.RequestResponse.Courses.Commands.UpdateCoursePrice;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateImage
{
    public class UpdateCoursePriceHandler(ZaminServices zaminServices, ICourseCommandRepository repository) : CommandHandler<UpdateCoursePriceCommand>(zaminServices)
    {
        private readonly ICourseCommandRepository _repository = repository;

        public override async Task<CommandResult> Handle(UpdateCoursePriceCommand command)
        {
            var teacher = _repository.GetGraph(command.CourseId);
            if (teacher is null)
                return await ResultAsync(Zamin.Core.RequestResponse.Common.ApplicationServiceStatus.NotFound);

            var parameter = _zaminServices.MapperFacade.Map<UpdateCoursePriceCommand, UpdatePriceParameter>(command);
            teacher.Handle(parameter);
            await _repository.CommitAsync();

            return await OkAsync();
        }
    }
}
