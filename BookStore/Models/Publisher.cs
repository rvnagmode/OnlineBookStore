using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BookStore.Models;

namespace BookStore.Models
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        [ScaffoldColumn(false)]
        public int PublisherId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string PublisherName { get; set; }
    }
}
