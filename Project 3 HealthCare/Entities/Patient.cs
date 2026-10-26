namespace HealthCare.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

        // Navigational Property (Many-to-Many with Doctor through Appointment)
        public ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();
    }
}
