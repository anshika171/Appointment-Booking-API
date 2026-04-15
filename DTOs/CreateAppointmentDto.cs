using System.ComponentModel.DataAnnotations;

namespace Appointment_Booking_Api.DTOs;

public class CreateAppointmentDto
{
    [Required]
    public string Name { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string TimeSlot { get; set; }
}