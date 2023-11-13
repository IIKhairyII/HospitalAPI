namespace API.Models.Patient
{
    public class PatientHistory
    {
        public string Clinic { get; set; }
        public string Doctor { get; set; }
        public string DoctorId { get; set; }
        public string DiseaseDesc { get; set; }
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
    }
}
