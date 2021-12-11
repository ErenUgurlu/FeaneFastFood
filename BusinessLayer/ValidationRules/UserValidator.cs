using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field can't be left blank");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field can't be left blank");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail field can't be left blank");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Name value can't contain less than two characters");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Name value must contain less than fifty characters");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Password value can't contain less than two characters");
            RuleFor(x => x.Password).MaximumLength(20).WithMessage("Password value must contain less than fifty characters");
            


        }
    }
}
