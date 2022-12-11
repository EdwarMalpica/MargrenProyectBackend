using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IProductsRepository
    {
        Task<Product> GetProducById(ProductId id);
        Task AddProduct (Product product);
        Task UpdateProduct (Product product);
    }
}
