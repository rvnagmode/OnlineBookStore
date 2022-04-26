using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BookStore.Models;

namespace BookStore.Models
{[Table("Category")]
    public class Category
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string CategoryName { get; set; }
    }
}
