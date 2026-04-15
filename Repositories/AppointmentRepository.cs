using Appointment_Booking_Api.Data;
using Appointment_Booking_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Booking_Api.Repositories;

public class AppointmentRepository : IAppointmentRepository
{
    private readonly AppDbContext _context;

    public AppointmentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Appointment> CreateAsync(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();
        return appointment;
    }

    public async Task<List<Appointment>> GetAllAsync()
    {
        return await _context.Appointments.ToListAsync();
    }

    public async Task<Appointment?> GetByIdAsync(int id)
    {
        return await _context.Appointments.FindAsync(id);
    }

    public async Task<bool> UpdateAsync(int id, Appointment updated)
    {
        var existing = await _context.Appointments.FindAsync(id);
        if (existing == null) return false;

        existing.Name = updated.Name;
        existing.Date = updated.Date;
        existing.TimeSlot = updated.TimeSlot;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null) return false;

        _context.Appointments.Remove(appointment);
        await _context.SaveChangesAsync();
        return true;
    }
}