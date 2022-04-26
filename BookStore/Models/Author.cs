
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BookStore.Models;

namespace BookStore.Models
{
    [Table("Author")]
    public class Author
    {
        [Key]
        [ScaffoldColumn(false)]
        public int AuthorId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string AuthorName { get; set; }
    }
}
