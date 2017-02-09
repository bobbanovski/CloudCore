using Microsoft.AspNetCore.Mvc;
using Core.Models;

namespace Core.Controllers
{
    [Route("api/[controller]")]
    public class PatientsController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody]Patient patient)
        {
          if (!ModelState.IsValid)
            return BadRequest(ModelState);

          // Save the patient in the database 
          // patientsService.AddPatient(patient);
          patient.Id = 1; // to simulate the generation of an ID 

          return Ok(patient); 
        }
    }
}
