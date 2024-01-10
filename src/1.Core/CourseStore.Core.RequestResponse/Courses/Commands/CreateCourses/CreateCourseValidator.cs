using CourseStore.Core.Resources;
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace CourseStore.Core.RequestResponse.Teachers.Commands.CreateTeachers
{
    public class CreateCourseValidator : AbstractValidator<CreateCourseCommand>
    {
        public CreateCourseValidator(ITranslator translator)
        {
            RuleFor(x => x.Title)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.FIRST_NAME])
               .Length(ProjectConsts.NAME_MIN_LENGTH, ProjectConsts.NAME_MAX_LENGTH)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.FIRST_NAME, ProjectConsts.NAME_MIN_LENGTH.ToString(), ProjectConsts.NAME_MAX_LENGTH.ToString()]);

            RuleFor(x => x.Price)
              .Cascade(CascadeMode.Stop)
              .GreaterThanOrEqualTo(ProjectConsts.PRICE_MIN_VALUE)
              .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_NUMBER_GRATER_OR_EQUAL_THAN, ProjectConsts.PRICE_MIN_VALUE.ToString()]);

            RuleFor(x => x.Description)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.LAST_NAME])
               .Length(ProjectConsts.DESCRIPTION_MIN_LENGTH, ProjectConsts.DESCRIPTION_MAX_LENGTH)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.DESCRIPTION, ProjectConsts.DESCRIPTION_MIN_LENGTH.ToString(), ProjectConsts.DESCRIPTION_MAX_LENGTH.ToString()]);

            RuleFor(x => x.ImageUrl)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.IMAGE_URL])
               .Length(ProjectConsts.DESCRIPTION_MIN_LENGTH, ProjectConsts.DESCRIPTION_MAX_LENGTH)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.DESCRIPTION, ProjectConsts.URI_MIN_LENGTH.ToString(), ProjectConsts.URI_MAX_LENGTH.ToString()]);


        }
    }
}
