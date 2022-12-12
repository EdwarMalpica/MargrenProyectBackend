using Margren.Domain.Entities;
using Margren.Domain.Repositories;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Infrastructure
{
    public class PlaceRepository : IPlaceRepository
    {
        DataBaseContext db;
        public PlaceRepository(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddPlace(Place place)
        {
            await db.AddAsync(place);
            await db.SaveChangesAsync();
        }


        public async Task<Place> GetPlaceById(PlaceId id)
        {
            return await db.LUGARES.FindAsync(id.value);
        }

        public Task UpdatePlace(Place place)
        {
            throw new NotImplementedException();
        }
    }
}
