using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ClinicAppoinmentTask.Model
{
    [PrimaryKey(nameof(BookingId), nameof(PID), nameof(CID))]
    public class Booking
    {
        [JsonIgnore]
        public int BookingId { get; set; }

        [ForeignKey("Patient")]
        public int PID { get; set; }

        [ForeignKey("Clinic")]
        public int CID { get; set; }
        public DateTime Date { get; set; }
        public int SlotNumber { get; set; } // Ensure validation (1-20)
        [JsonIgnore]
        public Patient Patient { get; set; }
        [JsonIgnore]
        public Clinic Clinic { get; set; }
    }
}
