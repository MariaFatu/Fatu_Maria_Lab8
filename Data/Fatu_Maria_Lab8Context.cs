using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fatu_Maria_Lab8.Models;

namespace Fatu_Maria_Lab8.Data
{
    public class Fatu_Maria_Lab8Context : DbContext
    {
        public Fatu_Maria_Lab8Context (DbContextOptions<Fatu_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Fatu_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Fatu_Maria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Fatu_Maria_Lab8.Models.Category> Category { get; set; }
    }
}
