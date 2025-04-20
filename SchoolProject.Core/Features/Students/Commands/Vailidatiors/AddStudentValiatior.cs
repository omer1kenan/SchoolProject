using FluentValidation;
using SchoolProject.Core.Features.Students.Commands.Model;

namespace SchoolProject.Core.Features.Students.Commands.Vailidatiors
{
    internal class AddStudentValiatior : AbstractValidator<AddStudentCommand>
    {
        public AddStudentValiatior()
        {
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name Must not be Empty")
                .NotNull().WithMessage("Name Must not be Null")
                .MaximumLength(10).WithMessage("Max Length 10");
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("{PropertyName} Must not be Empty")
                .NotNull().WithMessage("{PropertyValue} Must not be Null");
        }
        public void ApplyCustomValidationsRules() { }
    }
}
