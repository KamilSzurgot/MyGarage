using MyGarage.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Models
{
    public class RepairRepository : IRepairRepository
    {
        private readonly AppDbContext _appDbContext;

        public RepairRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Repair AddRepair(Repair repair)
        {
            var addedEntity = _appDbContext.Repairs.Add(repair);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public void DeleteRepair(int repairId)
        {
            var foundRepair = _appDbContext.Repairs.FirstOrDefault(e => e.RepairId == repairId);
            if (foundRepair == null) return;

            _appDbContext.Repairs.Remove(foundRepair);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Repair> GetAllRepairs()
        {
            return _appDbContext.Repairs;
        }

        public Repair GetRepairById(int repairId)
        {
            return _appDbContext.Repairs.FirstOrDefault(c => c.RepairId == repairId);
        }

        public Repair UpdateRepair(Repair repair)
        {
            var foundRepair = _appDbContext.Repairs.FirstOrDefault(e => e.RepairId == repair.RepairId);

            if (foundRepair != null)
            {
                foundRepair.Name = repair.Name;
                foundRepair.PhoneNumber = repair.PhoneNumber;
                foundRepair.Email = repair.Email;
                foundRepair.Comment = repair.Comment;
                foundRepair.CarInfo = repair.CarInfo;
                foundRepair.DeliveryDate = repair.DeliveryDate;
                foundRepair.IsFinished = repair.IsFinished;

                _appDbContext.SaveChanges();

                return foundRepair;
            }

            return null;
        }
    }
}
