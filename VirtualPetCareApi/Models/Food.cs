using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualPetCareApi.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string Name { get; set; }
        public int PetId { get; set; }
        [ForeignKey("PetId")]
        public Pet Pet { get; set; }
    }
}
