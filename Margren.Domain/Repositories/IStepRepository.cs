using Margren.Domain.Entities;
using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IStepRepository
    {
        Task<Step> GetStepById(StepId id);
        Task AddStep(Step step);
        Task DeleteStep(int id);
        Task UpdateStep(Step step);
    }
}
