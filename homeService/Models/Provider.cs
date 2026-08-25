using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace homeService.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public int NID { get; set; }
        [Required, MaxLength(50)]
        public string Service {  get; set; }
        [Range(0, 50)]
        public int ExpYears {  get; set; }
        public string? Image { get; set; }
        [MaxLength(50)]
        public string? Desc { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Provider> Providers { get; set; } = new List<Provider>();
    }
}
