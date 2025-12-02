using BillingAPI.DTOs;
using BillingAPI.Models;

namespace BillingAPI.Interfaces
{
    public interface IPatientService
    {
        Task<List<PatientDto>> GetAllPatientsAsync();
        Task<PatientDto?> GetPatientByIdAsync(int id);
        Task<PatientDto> CreatePatientAsync(CreatePatientDto dto);
    }
}
