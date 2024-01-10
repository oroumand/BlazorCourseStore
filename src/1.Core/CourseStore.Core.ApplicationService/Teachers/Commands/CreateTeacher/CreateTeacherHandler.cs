using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.Domain.Teachers.Entities;
using CourseStore.Core.Domain.Teachers.Parameters;
using CourseStore.Core.RequestResponse.Teachers.Commands.CreateTeachers;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace CourseStore.Core.ApplicationService.Teachers.Commands.CreateTeacher
{
    public class CreateTeacherHandler : CommandHandler<CreateTeacherCommand, int>
    {
        private readonly ITeacherCommandRepository _repository;

        public CreateTeacherHandler(ZaminServices zaminServices, ITeacherCommandRepository repository) : base(zaminServices)
        {
            _repository = repository;
        }

        public override async Task<CommandResult<int>> Handle(CreateTeacherCommand command)
        {
            var parameter = _zaminServices.MapperFacade.Map<CreateTeacherCommand, CreateParameter>(command);
            var teacher = new Teacher(parameter);
            await _repository.InsertAsync(teacher);
            await _repository.CommitAsync();

            return await OkAsync(teacher.Id);
        }
    }
}
