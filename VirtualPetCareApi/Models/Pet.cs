using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics;

namespace VirtualPetCareApi.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        // Other pet properties

        // Foreign keys
        public int UserId { get; set; }

        // Navigation properties
        public User User { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
