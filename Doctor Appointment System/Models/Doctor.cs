using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Doctor name is required!")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Name must be 3-50 characters!")]
        [Display(Name = "Doctor Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Specialization is required!")]
        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email format!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required!")]
        [StringLength(11, MinimumLength = 11,
        ErrorMessage = "Phone must be exactly 11 digits!")]
        [RegularExpression(@"^[0-9]*$",
        ErrorMessage = "Only numbers allowed!")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}