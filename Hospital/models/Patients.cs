using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.models
{
    public class Patients
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? states { get; set; }
        public DateOnly? Appointment { get; set; }
        public  List<DoctorPatients> DoctorPatient { get; set; }  
        
    }
}
