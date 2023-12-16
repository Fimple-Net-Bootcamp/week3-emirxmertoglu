using System.ComponentModel.DataAnnotations.Schema;

namespace VirtualPetCareApi.Models
{
    public class HealthStatus
    {
        public int HealthStatusId { get; set; }
        public string Status { get; set; }
        public int PetId { get; set; }
        [ForeignKey("PetId")]
        public Pet Pet { get; set; }
    }
}
