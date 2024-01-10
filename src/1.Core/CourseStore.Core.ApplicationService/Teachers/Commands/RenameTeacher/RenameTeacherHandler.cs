using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Commands.RenameTeachers;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.RenameTeacher
{
    public class RenameTeacherHandler(ZaminServices zaminServices, ITeacherCommandRepository repository) : CommandHandler<RenameTeacherCommand>(zaminServices)
    {
        private readonly ITeacherCommandRepository _repository = repository;

        public override async Task<CommandResult> Handle(RenameTeacherCommand command)
        {
            var teacher = _repository.GetGraph(command.TeacherId);
            if (teacher is null)
                return await ResultAsync(Zamin.Core.RequestResponse.Common.ApplicationServiceStatus.NotFound);

            var parameter = _zaminServices.MapperFacade.Map<RenameTeacherCommand, RenameParameter>(command);
            teacher.Handle(parameter);
            await _repository.CommitAsync();

            return await OkAsync();
        }
    }
}
