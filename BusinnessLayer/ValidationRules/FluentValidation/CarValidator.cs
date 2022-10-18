using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p=>p.CarName).NotEmpty();
            RuleFor(p=>p.DailyPrice).NotEmpty();
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p=>p.Description).MinimumLength(10);
            RuleFor(p=>p.Description).MaximumLength(40);

        }
    }
}
