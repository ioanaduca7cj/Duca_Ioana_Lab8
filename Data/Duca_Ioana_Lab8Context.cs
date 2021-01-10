using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Duca_Ioana_Lab8.Models;

namespace Duca_Ioana_Lab8.Data
{
    public class Duca_Ioana_Lab8Context : DbContext
    {
        public Duca_Ioana_Lab8Context (DbContextOptions<Duca_Ioana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Duca_Ioana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Duca_Ioana_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
