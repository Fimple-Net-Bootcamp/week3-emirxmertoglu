namespace VirtualPetCareApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public ICollection<Pet>? Pets { get; set; }
    }
}
