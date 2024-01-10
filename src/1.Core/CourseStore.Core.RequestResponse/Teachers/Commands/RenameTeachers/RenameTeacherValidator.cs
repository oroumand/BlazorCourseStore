using CourseStore.Core.Resources;
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.RenameTeachers
{
    public class RenameTeacherValidator : AbstractValidator<RenameTeacherCommand>
    {

        public RenameTeacherValidator(ITranslator translator)
        {
            RuleFor(x => x.TeacherId)
               .Cascade(CascadeMode.Stop)
               .GreaterThanOrEqualTo(ProjectConsts.ID_MIN_VALUE)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_NUMBER_GRATER_OR_EQUAL_THAN, ProjectConsts.ID_MIN_VALUE.ToString()]);

            RuleFor(x => x.FirstName)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.FIRST_NAME])
               .Length(ProjectConsts.NAME_MIN_LENGTH, ProjectConsts.NAME_MAX_LENGTH)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.FIRST_NAME, ProjectConsts.NAME_MIN_LENGTH.ToString(), ProjectConsts.NAME_MAX_LENGTH.ToString()]);

            RuleFor(x => x.LastName)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.LAST_NAME])
               .Length(ProjectConsts.NAME_MIN_LENGTH, ProjectConsts.NAME_MAX_LENGTH)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.LAST_NAME, ProjectConsts.NAME_MIN_LENGTH.ToString(), ProjectConsts.NAME_MAX_LENGTH.ToString()]);

        }
    }
}
