using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ClinicAppoinmentTask.Model
{
    public class Clinic
    {
        [Key]
        [JsonIgnore]
        public int CID { get; set; }
        public string Specialization { get; set; } // Unique
        public int NumberOfSlots { get; set; } // Max 20
        [JsonIgnore]
        public ICollection<Booking> Bookings = new List<Booking>(); 
    }
}
