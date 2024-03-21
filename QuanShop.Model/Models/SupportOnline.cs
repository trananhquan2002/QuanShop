using QuanShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Department { get; set; }
        public string? Skype { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Yahoo { get; set; }
        public string? Facebook { get; set; }
    }
}