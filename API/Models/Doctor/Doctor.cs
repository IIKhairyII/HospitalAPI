using API.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace API.Models.Doctor
{
    public class Doctor : CommonInfo
    {
        [Required, MaxLength(4)]
        public string GradYear { get; set; }
        [Required, MaxLength(20)]
        public string Specialization { get; set; }
        public List<DoctorHistory>? History { get; set; }
    }
}
