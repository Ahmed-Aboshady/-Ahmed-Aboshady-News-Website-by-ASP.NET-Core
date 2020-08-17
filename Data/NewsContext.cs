using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApp.Data
{
    public class NewsContext : DbContext
    {
       

        public NewsContext(DbContextOptions<NewsContext > options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Teammember> Teammembers { get; set; }
         
        public DbSet<ContactUS> Contacts { get; set; }
    }
}
