using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface ICoordinateRepository
    {
        Task<Coordinate> GetCoordinateById(CoordinateId id);
        Task AddCoordinate(Coordinate coordinate);
        Task UpdateCoordinate(Coordinate coordinate);
    }
}
