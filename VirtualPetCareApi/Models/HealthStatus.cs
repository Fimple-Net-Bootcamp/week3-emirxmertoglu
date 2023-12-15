namespace VirtualPetCareApi.Models
{
    public class HealthStatus
    {
        public int HealthStatusId { get; set; }
        public string Status { get; set; }
        // Other health status properties

        // Foreign key
        public int PetId { get; set; }

        // Navigation property
        public Pet Pet { get; set; }
    }
}
