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
    public class CoordinateReposiroty : ICoordinateRepository
    {
        DataBaseContext db;
        public CoordinateReposiroty(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddCoordinate(Coordinate coordinate)
        {
            await db.AddAsync(coordinate);
            await db.SaveChangesAsync();
        }

        public async Task<Coordinate> GetCoordinateById(CoordinateId id)
        {
            return await db.COORDENADAS.FindAsync(id.value);
        }

        public Task UpdateCoordinate(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }
    }
}
