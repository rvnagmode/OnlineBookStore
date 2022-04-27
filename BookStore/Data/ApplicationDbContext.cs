using BookStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
       public DbSet<Users> users { get; set; }
       public DbSet<Book> Book { get; set; }
       
        public DbSet<Category> cat { get; set; }
       public DbSet<Author> auth { get; set; }
       public DbSet<Publisher> pub { get; set; }
    }
}
