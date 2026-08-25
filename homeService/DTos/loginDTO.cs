using System.ComponentModel.DataAnnotations;

namespace homeService.DTos
{
    public class loginDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
