using QuanShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanShop.Model.Models
{
    [Table("Slides")]
    public class Slide : Auditable
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }
    }
}