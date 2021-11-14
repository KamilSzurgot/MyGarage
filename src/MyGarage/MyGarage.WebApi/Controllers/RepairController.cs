using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using MyGarage.Shared;
using MyGarage.WebApi.EmailHelper;
using MyGarage.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarage.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairController : Controller
    {
        private readonly IRepairRepository _repairRepository;
        private readonly IEmailSender _emailSender;
        private readonly SmsService _sms;

        public RepairController(IRepairRepository repairRepository, IEmailSender emailSender, SmsService sms)
        {
            _repairRepository = repairRepository;
            _emailSender = emailSender;
            _sms = sms;
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
            if (repair.IsFinished == true)
            {
                _sms.SendSms(repair.PhoneNumber, "+48885238770", "Hello, your car is ready to pick up. Sincerely, MyGarage");
            }

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
