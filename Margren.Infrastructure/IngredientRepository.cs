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
    public class IngredientRepository : IIngredientRepository
    {
        DataBaseContext db;
        public IngredientRepository(DataBaseContext db)
        {
            this.db = db;
        }
        public Task AddIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIngredientById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Ingredient>> GetListIngredientById(PrescriptionId id)
        {
            return  db.INGREDIENTES.Where(c => c.id_prescription == id.value).ToList();
        }

        public Task UpdateIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
