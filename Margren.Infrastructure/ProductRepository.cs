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
    public class ProductRepository : IProductsRepository
    {
        DataBaseContext db;
        public ProductRepository(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddProduct(Product product)
        {
            await db.AddAsync(product);
            await db.SaveChangesAsync();
        }

        public async Task<Product> GetProducById(ProductId id)
        {
            return await db.PRODUCTOS.FindAsync(id.value);
        }

        public Task UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
