using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Commands.UpdateDescription;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateDescription
{
    public class UpdateDescriptionHandler(ZaminServices zaminServices, ITeacherCommandRepository repository) : CommandHandler<UpdateDescriptionCommand>(zaminServices)
    {
        private readonly ITeacherCommandRepository _repository = repository;

        public override async Task<CommandResult> Handle(UpdateDescriptionCommand command)
        {
            var teacher = _repository.GetGraph(command.TeacherId);
            if (teacher is null)
                return await ResultAsync(Zamin.Core.RequestResponse.Common.ApplicationServiceStatus.NotFound);

            var parameter = _zaminServices.MapperFacade.Map<UpdateDescriptionCommand, UpdateDescriptionParameter>(command);
            teacher.Handle(parameter);
            await _repository.CommitAsync();

            return await OkAsync();
        }
    }
}
