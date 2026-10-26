namespace HealthCare.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Specialization { get; set; } = string.Empty;

        // Navigational Property (Many-to-Many with Patient through Appointment)
        public ICollection<Appointment> Appointments { get; set; } = new HashSet<Appointment>();
    }
}
