using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace appgamestore.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }

        public DbSet<appgamestore.Models.Ventas> DataVentas { get; set;}
        
    }
}