using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using superheroic.Models;

namespace superheroic.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Super> Supers {get; set;}
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
