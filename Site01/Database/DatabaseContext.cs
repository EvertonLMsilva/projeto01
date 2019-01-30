using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Palavra> Palavras { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //Ef - Garatnir que o banco seje criado pelo -EF - Code first

            Database.EnsureCreated();
        }
    }
}
