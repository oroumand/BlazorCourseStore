using CourseStore.Core.Resources;
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace CourseStore.Core.RequestResponse.Teachers.Command.UpdateImageUrl
{
    internal class UpdateImageUrlValidator : AbstractValidator<UpdateImageUrlCommand>
    {

        public UpdateImageUrlValidator(ITranslator translator)
        {
            RuleFor(x => x.TeacherId)
               .Cascade(CascadeMode.Stop)
               .GreaterThanOrEqualTo(ProjectConsts.ID_MIN_VALUE)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_NUMBER_GRATER_OR_EQUAL_THAN, ProjectConsts.ID_MIN_VALUE.ToString()]);

            RuleFor(x => x.ImageUrl)
               .Cascade(CascadeMode.Stop)
               .NotEmpty()
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_REQUIRED, ProjectTranslation.IMAGE_URL])
               .Length(ProjectConsts.DESCRIPTION_MIN_LENGTH, ProjectConsts.DESCRIPTION_MAX_LENGTH)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_STRING_LENGTH_BETWEEN, ProjectTranslation.DESCRIPTION, ProjectConsts.URI_MIN_LENGTH.ToString(), ProjectConsts.URI_MAX_LENGTH.ToString()]);

        }
    }
}
