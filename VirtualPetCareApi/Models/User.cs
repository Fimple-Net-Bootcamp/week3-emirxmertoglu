namespace VirtualPetCareApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        // Other user properties

        // Navigation properties
        public ICollection<Pet> Pets { get; set; }
    }
}
