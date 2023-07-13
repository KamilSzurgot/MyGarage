using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Models
{
    public interface IRepairRepository
    {
        IEnumerable<Repair> GetAllRepairs();
        Repair GetRepairById(int repairId);
        Repair AddRepair(Repair repair);
        Repair UpdateRepair(Repair repair);
        void DeleteRepair(int repairId);
    }
}
