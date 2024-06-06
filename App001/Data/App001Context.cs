using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App001.Models
{
    public class App001Context : DbContext
    {
        public App001Context (DbContextOptions<App001Context> options)
            : base(options)
        {
        }

        public DbSet<App001.Models.Aluno> Aluno { get; set; }
    }
}
