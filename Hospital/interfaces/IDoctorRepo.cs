using Hospital.DTOs;

namespace Hospital.interfaces
{
    public interface IDoctorRepo
    { 
       public DoctorDto GetDoctorByName(string name);
        
    }
}
