using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BookStore.Models;

namespace BookStore.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        [ScaffoldColumn(false)]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [Required]
        public int PublisherId { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int BookPrice { get; set; }
    }
}
