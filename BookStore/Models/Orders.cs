using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }
        [Required]
        public int BookId { get; set; }
        [NotMapped]
        public string BookName { get; set; }
        [NotMapped]
        public int BookPrice { get; set; }
        [NotMapped]
        public int BookQuantity { get; set; }
        [Required]
        public int BookTotalBill { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int OrderQuantity { get; set; }
    }
}
