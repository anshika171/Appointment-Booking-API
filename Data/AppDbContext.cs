using Appointment_Booking_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Booking_Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Appointment> Appointments { get; set; }
}