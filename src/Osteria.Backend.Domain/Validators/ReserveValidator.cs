using Osteria.Backend.Core.Models;
using FluentValidation;

namespace Osteria.Backend.Domain.Validators
{
    public class ReserveValidator : AbstractValidator<Reserve>
    {
        private readonly int _minimumPeople;

        public ReserveValidator(int minimumPeople)
        {
            _minimumPeople = minimumPeople;
        }

        public ReserveValidator()
        {
            RuleFor(e => e.People)
                .GreaterThanOrEqualTo(_minimumPeople)
                .WithMessage($"A reserva deve ser feita com pelo menos {_minimumPeople} pessoa(s)");
        }

    }
}
