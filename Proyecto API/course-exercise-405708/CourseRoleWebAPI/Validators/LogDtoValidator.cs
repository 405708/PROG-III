using CourseRoleWebAPI.Dtos;
using FluentValidation;

namespace CourseRoleWebAPI.Validators
{
    public class LogDtoValidator : AbstractValidator<LogDto>
    {
        public LogDtoValidator() {
            RuleFor(x => x.Id)
                .NotEmpty();
                /*.Must(x => Guid.TryParse(x, out var guid))
                     .WithMessage("El formato de id debe ser guid");*/
            RuleFor(x => x.Data)
                .NotEmpty()
                .MinimumLength(10).WithMessage("Largo minimo 10")
                .MaximumLength(100).WithMessage("Largo maximo 100");
            RuleFor(x => x.Date)
                .NotEmpty();
            RuleFor(x => x.User)
                .NotEmpty()
                .MinimumLength(5).WithMessage("Largo minimo 5")
                .MaximumLength(10).WithMessage("Largo maximo 10");
        }
    }
}
