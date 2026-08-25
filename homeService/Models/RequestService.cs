using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace homeService.Models
{
    public class RequestService
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Request {  get; set; }
        [Required, MaxLength(100)]
        public string Location { get; set; }
        [Required, MaxLength(100)]
        public string Desc { get; set; }

        [ForeignKey("Providers")]
        public int ProviderId {  get; set; }
        public Provider Providers { get; set; }

        [ForeignKey("User")]
        public string UserId {  get; set; }
        public User User { get; set; }
    }
}
