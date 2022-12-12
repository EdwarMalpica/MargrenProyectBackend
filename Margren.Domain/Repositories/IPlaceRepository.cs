using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IPlaceRepository
    {
        Task<Place> GetPlaceById(PlaceId id);
        Task AddPlace(Place place);
        Task UpdatePlace(Place place);
    }
}
