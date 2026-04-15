using Appointment_Booking_Api.DTOs;
using Appointment_Booking_Api.Models;
using Appointment_Booking_Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Appointment_Booking_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _service;
    private readonly ILogger<AppointmentController> _logger;

    public AppointmentController(IAppointmentService service, ILogger<AppointmentController> logger)
    {
        _service = service;
        _logger = logger;
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create(CreateAppointmentDto dto)
    {
        _logger.LogInformation("Creating appointment for {Name}", dto.Name);

        var appointment = new Appointment
        {
            Name = dto.Name,
            Date = dto.Date,
            TimeSlot = dto.TimeSlot
        };

        var result = await _service.CreateAppointmentAsync(appointment);

        return Ok(new { success = true, data = result });
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        _logger.LogInformation("Fetching all appointments");

        var result = await _service.GetAllAppointmentsAsync();

        return Ok(new { success = true, data = result });
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateAppointmentDto dto)
    {
        _logger.LogInformation("Updating appointment {Id}", id);

        var appointment = new Appointment
        {
            Name = dto.Name,
            Date = dto.Date,
            TimeSlot = dto.TimeSlot
        };

        var updated = await _service.UpdateAppointmentAsync(id, appointment);

        if (!updated)
            return NotFound(new { success = false, message = "Not found" });

        return Ok(new { success = true, message = "Updated successfully" });
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        _logger.LogInformation("Deleting appointment {Id}", id);

        var deleted = await _service.DeleteAppointmentAsync(id);

        if (!deleted)
            return NotFound(new { success = false, message = "Not found" });

        return Ok(new { success = true, message = "Deleted successfully" });
    }
}