using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IPrescriptionRepository
    {
        Task<Prescription> GetPrescriptionById(PrescriptionId id);
        Task AddPrescription(Prescription prescription);
        Task UpdatePrescription(Prescription prescription);
    }
}
