using System.ComponentModel.DataAnnotations;

namespace UserMvcApp.DTO
{
    public class UserSignUpDTO
    {
        //Με attributres κανουμε συντακτικό validation, με το fluent validation κανουμε και λογικούς ελέγχους


        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username should be between 2-50 characters")]
        public string? Username { get; set; }


        [StringLength(50, ErrorMessage = "Firstname should be maximum 50 characters")]
        public string? Firstname { get; set; }


        [StringLength(50, ErrorMessage = "Lastname should be maximum 50 characters")]
        public string? Lastname { get; set; }

        [StringLength(100, ErrorMessage = "E-mail should not exceed 100 characters")]
        [EmailAddress(ErrorMessage = "Invalid e-mail Address")]
        public string? Email { get; set; }


        [StringLength(32, ErrorMessage = "Password should not exceed 32 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*\d)(?=.*[A-Z])(?=.*\W).{8, }$", ErrorMessage = "Password must contain at least one lowercase letter,"
            + " one uppercase letter, one digit and one special character")]
        public string? Password { get; set; }


        [StringLength(10, ErrorMessage = "Phone number should not exceed 10 characters")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string? PhoneNumber { get; set; }


        [StringLength(100, ErrorMessage = "Institution should not exceed 100 characters")]
        public string? Institution { get; set; }


        [StringLength(50, ErrorMessage = "User role should not exceed 50 characters")]
        public string? UserRole { get; set; }
    }
}
