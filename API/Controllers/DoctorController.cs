using API.Models.Doctor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        [HttpGet]
        public ActionResult Doctors()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Doctors(Doctor doctor)
        {
            return Ok();
        }

        [HttpDelete]
        public ActionResult Doctors(int key)
        {
            return Ok();
        }

        //[HttpGet]
        //public ActionResult Doctors([FromQuery] int doctorKey)
        //{
        //    return Ok();
        //}
    }
}
