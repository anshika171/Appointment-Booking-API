using Appointment_Booking_Api.Models;

namespace Appointment_Booking_Api.Services;

public interface IAppointmentService
{
    Task<Appointment> CreateAppointmentAsync(Appointment appointment);
    Task<List<Appointment>> GetAllAppointmentsAsync();
    Task<Appointment?> GetAppointmentByIdAsync(int id);
    Task<bool> UpdateAppointmentAsync(int id, Appointment appointment);
    Task<bool> DeleteAppointmentAsync(int id);
}