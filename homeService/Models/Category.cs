using System.ComponentModel.DataAnnotations;

namespace homeService.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200), Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Desc { get; set; }
        [MaxLength(200)]
        public string? Image { get; set; }

        public ICollection<Provider> Providers { get; set; } = new List<Provider>();

    }
}
