using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace DataLayer
{
    public class BillValidator : AbstractValidator<Money>
    {
        public BillValidator(IDictionary<string, Banknote> validData) 
        {
            RuleFor(x => x)
                .Must(x => validData.Values.Any(v => v.amount.Equals(x.amount) && v.symbol.Equals(x.symbol)))
                .WithMessage("Item doesn't match any valid item");
        }
    }
}
