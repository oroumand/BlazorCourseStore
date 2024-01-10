using CourseStore.Core.Contracts.Courses.Commands;
using CourseStore.Core.Contracts.Teachers.Commands;
using CourseStore.Core.Domain.Courses.Entities;
using CourseStore.Core.Domain.Courses.Parameters;
using CourseStore.Core.RequestResponse.Courses.Commands.CreateCourses;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace CourseStore.Core.ApplicationService.Courses.Commands.CreateCourse
{
    public class CreateCourseHandler : CommandHandler<CreateCourseCommand, int>
    {
        private readonly ICourseCommandRepository _repository;
        private readonly ITeacherCommandRepository _teacherRepository;

        public CreateCourseHandler(ZaminServices zaminServices, ICourseCommandRepository repository, ITeacherCommandRepository teacherRepository) : base(zaminServices)
        {
            _repository = repository;
            _teacherRepository = teacherRepository;
        }

        public override async Task<CommandResult<int>> Handle(CreateCourseCommand command)
        {

            var teacher = _teacherRepository.GetGraph(command.TeacherId);
            if (teacher is null)
                return await ResultAsync(0,Zamin.Core.RequestResponse.Common.ApplicationServiceStatus.ValidationError);

            var parameter = _zaminServices.MapperFacade.Map<CreateCourseCommand, CreateParameter>(command);
            var course = new Course(parameter);
            await _repository.InsertAsync(course);
            await _repository.CommitAsync();

            return await OkAsync(course.Id);
        }
    }
}
