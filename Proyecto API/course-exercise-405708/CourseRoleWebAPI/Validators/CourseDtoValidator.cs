using CourseRoleWebAPI.Dtos;
using FluentValidation;

namespace CourseRoleWebAPI.Validators
{
    public class CourseDtoValidator : AbstractValidator<CourseDto>
    {
        public CourseDtoValidator() {
            RuleFor(x => x.Id)
                .NotEmpty();
            /*.Must(x => Guid.TryParse(x, out var guid))
                 .WithMessage("El formato de id debe ser guid");*/
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(6).WithMessage("Largo minimo 6")
                .MaximumLength(50).WithMessage("Largo maximo 50");
            RuleFor(x => x.Description)
                .NotEmpty()
                .MinimumLength(5).WithMessage("Largo minimo 5")
                .MaximumLength(100).WithMessage("Largo maximo 100");
        }
    }
}
