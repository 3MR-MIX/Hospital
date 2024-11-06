using Hospital.DTOs;
using Hospital.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepo _repo;
        public DoctorsController(IDoctorRepo doctorRepo)
        {
            _repo = doctorRepo;
        }
        [HttpGet("{name}")]
        public  IActionResult DisplayDotorbyName (string name)
        {
            var doctorDto = _repo.GetDoctorByName (name); 
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState.IsValid);
            }
            return Ok(doctorDto);
        }

    }
}
