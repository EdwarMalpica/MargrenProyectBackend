using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IIngredientRepository
    {
        Task<List<Ingredient> > GetListIngredientById(PrescriptionId id);
        Task AddIngredient(Ingredient ingredient);
        Task DeleteIngredientById(int id);
        Task UpdateIngredient(Ingredient ingredient);
    }
}
