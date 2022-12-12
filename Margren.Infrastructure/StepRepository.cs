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
    public class StepRepository : IStepRepository
    {
        DataBaseContext db;
        public StepRepository(DataBaseContext db)
        {
            this.db = db;
        }

        public async Task AddStep(Step step)
        {
            await db.AddAsync(step);
            await db.SaveChangesAsync();
        }

        public Task DeleteStep(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Step> GetStepById(StepId id)
        {
            return await db.PASOS.FindAsync(id.value);
        }

        public Task UpdateStep(Step step)
        {
            throw new NotImplementedException();
        }
    }
}
