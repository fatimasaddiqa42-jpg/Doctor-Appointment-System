using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorAppointmentSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Appointment date is required!")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; } = "Pending";

        [StringLength(200,
        ErrorMessage = "Notes cannot exceed 200 characters!")]
        [Display(Name = "Notes (Optional)")]
        public string? Notes { get; set; }

        [Required(ErrorMessage = "Please select a doctor!")]
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }

        [Required(ErrorMessage = "Please select a patient!")]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }
    }
}