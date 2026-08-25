using System.ComponentModel.DataAnnotations;

namespace homeService.DTos
{
    public class RegisterDTO
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
