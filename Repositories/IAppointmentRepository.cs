using Appointment_Booking_Api.Models;

namespace Appointment_Booking_Api.Repositories;

public interface IAppointmentRepository
{
    Task<Appointment> CreateAsync(Appointment appointment);
    Task<List<Appointment>> GetAllAsync();
    Task<Appointment?> GetByIdAsync(int id);
    Task<bool> UpdateAsync(int id, Appointment appointment);
    Task<bool> DeleteAsync(int id);
}