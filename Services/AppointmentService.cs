using Appointment_Booking_Api.Models;
using Appointment_Booking_Api.Repositories;

namespace Appointment_Booking_Api.Services;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _repo;

    public AppointmentService(IAppointmentRepository repo)
    {
        _repo = repo;
    }

    public async Task<Appointment> CreateAppointmentAsync(Appointment appointment)
        => await _repo.CreateAsync(appointment);

    public async Task<List<Appointment>> GetAllAppointmentsAsync()
        => await _repo.GetAllAsync();

    public async Task<Appointment?> GetAppointmentByIdAsync(int id)
        => await _repo.GetByIdAsync(id);

    public async Task<bool> UpdateAppointmentAsync(int id, Appointment appointment)
        => await _repo.UpdateAsync(id, appointment);

    public async Task<bool> DeleteAppointmentAsync(int id)
        => await _repo.DeleteAsync(id);
}