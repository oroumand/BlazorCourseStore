using CourseStore.Core.Resources;
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace CourseStore.Core.RequestResponse.Courses.Commands.UpdateCourseDescription
{
    public class UpdateCourseDescriptionValidator : AbstractValidator<UpdateCourseDescriptionCommand>
    {

        public UpdateCourseDescriptionValidator(ITranslator translator)
        {
            RuleFor(x => x.CourseId)
               .Cascade(CascadeMode.Stop)
               .GreaterThanOrEqualTo(ProjectConsts.ID_MIN_VALUE)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_NUMBER_GRATER_OR_EQUAL_THAN, ProjectConsts.ID_MIN_VALUE.ToString()]);

            RuleFor(x => x.Description)
                        .Cascade(CascadeMode.Stop)
                        .NotEmpty()
                        .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.LAST_NAME])
                        .Length(ProjectConsts.DESCRIPTION_MIN_LENGTH, ProjectConsts.DESCRIPTION_MAX_LENGTH)
                        .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.DESCRIPTION, ProjectConsts.DESCRIPTION_MIN_LENGTH.ToString(), ProjectConsts.DESCRIPTION_MAX_LENGTH.ToString()]);
        }
    }
}
