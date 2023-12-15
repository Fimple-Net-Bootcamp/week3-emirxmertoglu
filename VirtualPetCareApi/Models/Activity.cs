namespace VirtualPetCareApi.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        // Other activity properties

        // Foreign key
        public int PetId { get; set; }

        // Navigation property
        public Pet Pet { get; set; }
    }
}
