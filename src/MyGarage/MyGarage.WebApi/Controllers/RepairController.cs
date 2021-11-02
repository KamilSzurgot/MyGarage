using Microsoft.AspNetCore.Mvc;
using MyGarage.Shared;
using MyGarage.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Controllers
{
    public class RepairController : Controller
    {
        private readonly IRepairRepository _repairRepository;

        public RepairController(IRepairRepository repairRepository)
        {
            _repairRepository = repairRepository;
        }

        [HttpGet]
        public IActionResult GetAllRepairs()
        {
            return Ok(_repairRepository.GetAllRepairs());
        }

        [HttpGet("{id}")]
        public IActionResult GetRepairById(int id)
        {
            return Ok(_repairRepository.GetRepairById(id));
        }

        [HttpPost]
        public IActionResult CreateRepair([FromBody] Repair repair)
        {
            if (repair == null)
                return BadRequest();

            if (repair.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdRepair = _repairRepository.AddRepair(repair);

            return Created("repair", createdRepair);
        }

        [HttpPut]
        public IActionResult UpdateRepair([FromBody] Repair repair)
        {
            if (repair == null)
                return BadRequest();

            if (repair.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var repairToUpdate = _repairRepository.GetRepairById(repair.RepairId);

            if (repairToUpdate == null)
                return NotFound();

            _repairRepository.UpdateRepair(repair);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRepair(int id)
        {
            if (id == 0)
                return BadRequest();

            var repairToDelete = _repairRepository.GetRepairById(id);
            if (repairToDelete == null)
                return NotFound();

            _repairRepository.DeleteRepair(id);

            return NoContent();//success
        }
    }
}
