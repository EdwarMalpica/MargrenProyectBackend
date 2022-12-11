using Margren.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Repositories
{
    public interface IStepRepository
    {
        Task<Step> GetStepById(int id);
        Task AddStep(Step step);
        Task DeleteStep(int id);
        Task UpdateStep(Step step);
    }
}
