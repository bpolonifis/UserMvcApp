
using System.ComponentModel.DataAnnotations;

namespace UserMvcApp.DTO
{
    public class UserPatchDTO
    {

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username should be between 2-50 characters")]
        public string? Username { get; set; }



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
    }
}
