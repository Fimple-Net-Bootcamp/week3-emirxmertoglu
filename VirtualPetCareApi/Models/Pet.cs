using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace VirtualPetCareApi.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public HealthStatus HealthStatus { get; set; }
        public ICollection<Activity>? Activities { get; set; }
    }
}
