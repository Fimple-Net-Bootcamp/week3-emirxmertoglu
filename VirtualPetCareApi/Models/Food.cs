namespace VirtualPetCareApi.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        // Other food properties

        // Foreign key
        public int PetId { get; set; }

        // Navigation property
        public Pet Pet { get; set; }
    }
}
