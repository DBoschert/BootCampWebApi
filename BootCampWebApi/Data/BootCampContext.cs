using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BootCampWebApi.Models;

namespace BootCampWebApi.Data
{
    public class BootCampContext : DbContext
    {
        public BootCampContext (DbContextOptions<BootCampContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; } = default!;
        public DbSet<Assessment> Assessments { get; set; } = default!;
        public DbSet<Score> Scores { get; set; } = default!;
    }
}
