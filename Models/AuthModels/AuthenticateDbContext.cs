using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Api.Models.AuthModels
{
    /// <summary>
    /// Provides a database context for the BookStore application using Entity Framework Core and Identity Framework.
    /// </summary>
    public class AuthenticateDbContext : IdentityDbContext<ApplicationUser>
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationDbContext class with the specified DbContext options.
        /// </summary>
        /// <param name="options">The options to be used by the DbContext.</param>
        public AuthenticateDbContext(DbContextOptions<AuthenticateDbContext> options) : base(options)
        {
            // The base constructor handles initializing the DbContext with the provided options.
        }
        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              if (!optionsBuilder.IsConfigured)
              {
                  optionsBuilder.UseSqlServer("AuthenticateConnection", b => b.MigrationsAssembly("StudentManagement.data")); 
              }
          }
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              if (!optionsBuilder.IsConfigured)
              {
                  optionsBuilder.UseSqlServer(Configuration.GetConnectionString("AuthenticateConnection"));
              }
          }*/

    }
}
