using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }

        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}