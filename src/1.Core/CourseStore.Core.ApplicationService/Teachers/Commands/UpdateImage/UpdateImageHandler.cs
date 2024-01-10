using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Commands.UpdateImage;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.UpdateImage
{
    public class UpdateImageHandler(ZaminServices zaminServices, ITeacherCommandRepository repository) : CommandHandler<UpdateImageCommand>(zaminServices)
    {
        private readonly ITeacherCommandRepository _repository = repository;

        public override async Task<CommandResult> Handle(UpdateImageCommand command)
        {
            var teacher = _repository.GetGraph(command.TeacherId);
            if (teacher is null)
                return await ResultAsync(Zamin.Core.RequestResponse.Common.ApplicationServiceStatus.NotFound);

            var parameter = _zaminServices.MapperFacade.Map<UpdateImageCommand, UpdateImageParameter>(command);
            teacher.Handle(parameter);
            await _repository.CommitAsync();

            return await OkAsync();
        }
    }
}
