using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace StudentManagement.Api.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
    }
}
