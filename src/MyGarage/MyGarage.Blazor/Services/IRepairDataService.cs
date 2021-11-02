using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.Blazor.Services
{
    public interface IRepairDataService
    {
        Task<IEnumerable<Repair>> GetAllRepairs();
        Task<Repair> GetRepairDetails(int repairId);
        Task<Repair> AddRepair(Repair repair);
        Task UpdateRepair(Repair repair);
        Task DeleteRepair(int repairId);
    }
}
