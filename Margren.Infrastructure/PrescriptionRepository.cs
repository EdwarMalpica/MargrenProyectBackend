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
    public class PrescriptionRepository : IPrescriptionRepository
    {
        DataBaseContext db;
        public PrescriptionRepository(DataBaseContext db)
        {
            this.db = db;
        }
    
        public async Task AddPrescription(Prescription prescription)
        {
            await db.AddAsync(prescription);
            await db.SaveChangesAsync();
        }

        public async Task<Prescription> GetPrescriptionById(PrescriptionId id)
        {
            return await db.RECETAS.FindAsync(id.value);
        }

        public Task UpdatePrescription(Prescription prescription)
        {
            throw new NotImplementedException();
        }
    }
}
