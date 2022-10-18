using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<Users>
    {
        public UserValidator()
        {
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.Password).MinimumLength(5);
            RuleFor(p => p.Password).MaximumLength(12);

        }
    }
}
