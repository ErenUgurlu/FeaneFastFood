using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Name field can't be left blank");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail field can't be left blank");
        }
    }
}
