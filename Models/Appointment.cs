namespace Appointment_Booking_Api.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public DateTime Date { get; set; }
        public string TimeSlot { get; set; } = string.Empty;

    }
}