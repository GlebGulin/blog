using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.ViewModels;

namespace Blog.Models.Data
{
    public class Db : DbContext
    {
        public DbSet<Articles> article { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Comments> comment { get; set; }
       

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=blogdb;Username=postgres;Password=28054;");
        }
      
    }
}
