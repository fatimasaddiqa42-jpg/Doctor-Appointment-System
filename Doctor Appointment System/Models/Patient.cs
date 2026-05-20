using System.ComponentModel.DataAnnotations;

namespace DoctorAppointmentSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Patient name is required!")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Name must be 3-50 characters!")]
        [Display(Name = "Patient Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Date of birth is required!")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email format!")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required!")]
        [StringLength(11, MinimumLength = 11,
        ErrorMessage = "Phone must be exactly 11 digits!")]
        [RegularExpression(@"^[0-9]*$",
        ErrorMessage = "Only numbers allowed!")]
        [Display(Name = "Phone Number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Address is required!")]
        [StringLength(100, MinimumLength = 5,
        ErrorMessage = "Address must be 5-100 characters!")]
        [Display(Name = "Address")]
        public string? Address { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
    }
}