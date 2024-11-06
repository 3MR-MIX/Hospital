using System.ComponentModel.DataAnnotations;

namespace Hospital.models
{
    public class Doctors
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? specialty { get; set; }
        public int? MangerId { get; set; }
        public Manager Manager { get; set; }
        public List<DoctorPatients> DoctorPatient { get; set; }
    }
}
