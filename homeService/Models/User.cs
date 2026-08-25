using Microsoft.AspNetCore.Identity;

namespace homeService.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }



        public ICollection<RequestService> RequestServices = new List<RequestService>();

    }
}
