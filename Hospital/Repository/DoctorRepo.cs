using Hospital.DTOs;
using Hospital.interfaces;

namespace Hospital.Repository
{
    public class DoctorRepo : IDoctorRepo
    {
        private readonly HospitalDbContext _context;
        public DoctorRepo(HospitalDbContext context) 
        { 
            _context = context;
        }
        public DoctorDto GetDoctorByName(string name)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.Name == name);

            DoctorDto doctorDto = new DoctorDto
            {
                Name = doctor.Name,
                Specialty = doctor.specialty,
                ManagerName = doctor.Manager.Name
            };
            return doctorDto;
        }
    }
}
