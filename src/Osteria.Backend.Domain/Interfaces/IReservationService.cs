using LanguageExt.Common;
using Osteria.Backend.Core.Models;

namespace Osteria.Backend.Domain.Interfaces
{
    public interface IReservationService
    {
        Result<Reserve> Add(Reserve reserve);
    }
}
