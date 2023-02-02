using Osteria.Backend.Domain.Interfaces;
using Osteria.Backend.Core.Models;
using LanguageExt.Common;
using FluentValidation;

namespace Osteria.Backend.Domain.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IValidator<Reserve> _validator;

        public ReservationService(IValidator<Reserve> validator)
        {
            _validator = validator;
        }

        public Result<Reserve> Add(Reserve reserve)
        {
            var validationResult = _validator.Validate(reserve);

            if (!validationResult.IsValid)
            {
                var validationException = new ValidationException(validationResult.Errors);

                return new Result<Reserve>(validationException);
            }

            return reserve;
        }
    }
}
