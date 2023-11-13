using API.Models.Common;
using API.Models.Doctor;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        public DoctorController(AppData data)
        {
            _data = data;
        }
        private AppData _data;

        [HttpGet]
        public ActionResult Doctors()
        {
            try
            {
                var doctors = _data.doctors.OrderBy(d => d.Key).ToList();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
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
