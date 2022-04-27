using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BookStore.Models;

namespace BookStore.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [ScaffoldColumn(false)]
        public int UserId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [MinLength(5)]
        [MaxLength(50)]
        public string EmailId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(5)]
        [MaxLength(20)]
        public string Passwords { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public int RoleId { get; set; }


    }
}
