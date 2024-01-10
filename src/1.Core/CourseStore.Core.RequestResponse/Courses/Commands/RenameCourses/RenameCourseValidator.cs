using CourseStore.Core.Resources;
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace CourseStore.Core.RequestResponse.Courses.Commands.RenameCourses
{
    public class RenameCourseValidator : AbstractValidator<RenameCourseCommand>
    {

        public RenameCourseValidator(ITranslator translator)
        {
            RuleFor(x => x.CourseId)
               .Cascade(CascadeMode.Stop)
               .GreaterThanOrEqualTo(ProjectConsts.ID_MIN_VALUE)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_NUMBER_GRATER_OR_EQUAL_THAN, ProjectConsts.ID_MIN_VALUE.ToString()]);

            RuleFor(x => x.Title)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.FIRST_NAME])
               .Length(ProjectConsts.NAME_MIN_LENGTH, ProjectConsts.NAME_MAX_LENGTH)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.FIRST_NAME, ProjectConsts.NAME_MIN_LENGTH.ToString(), ProjectConsts.NAME_MAX_LENGTH.ToString()]);

        }
    }
}
