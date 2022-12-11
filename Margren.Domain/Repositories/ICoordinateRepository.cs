using Margren.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface ICoordinateRepository
    {
        Task<Coordinate> GetCoordinateById(int id);
        Task AddCoordinate(Coordinate coordinate);
        Task UpdateCoordinate(Coordinate coordinate);
    }
}
