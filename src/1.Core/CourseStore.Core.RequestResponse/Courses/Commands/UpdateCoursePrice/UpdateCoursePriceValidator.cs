using CourseStore.Core.Resources;
using FluentValidation;
using Zamin.Extensions.Translations.Abstractions;

namespace CourseStore.Core.RequestResponse.Courses.Commands.UpdateCoursePrice
{
    public class UpdateCoursePriceValidator : AbstractValidator<UpdateCoursePriceCommand>
    {

        public UpdateCoursePriceValidator(ITranslator translator)
        {
            RuleFor(x => x.CourseId)
               .Cascade(CascadeMode.Stop)
               .GreaterThanOrEqualTo(ProjectConsts.ID_MIN_VALUE)
               .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_NUMBER_GRATER_OR_EQUAL_THAN, ProjectConsts.ID_MIN_VALUE.ToString()]);

            RuleFor(x => x.Price)
              .Cascade(CascadeMode.Stop)
              .GreaterThanOrEqualTo(ProjectConsts.PRICE_MIN_VALUE)
              .WithMessage(translator[ProjectValidationError.VALIDATION_ERROR_NUMBER_GRATER_OR_EQUAL_THAN, ProjectConsts.PRICE_MIN_VALUE.ToString()]);

        }
    }
}
