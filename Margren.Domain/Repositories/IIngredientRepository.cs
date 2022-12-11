using Margren.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IIngredientRepository
    {
        Task<Ingredient> GetIngredientById(int id);
        Task AddIngredient(Ingredient ingredient);
        Task DeleteIngredientById(int id);
        Task UpdateIngredient(Ingredient ingredient);
    }
}
