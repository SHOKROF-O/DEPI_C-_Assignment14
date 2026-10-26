namespace HealthCare.Entities
{
    // Joining table for the Many-to-Many between Patient and Doctor
    public class Appointment
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
    }
}
