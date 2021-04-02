using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RAZORCRUD.Models;

    public class RAZORCRUDBookContext : DbContext
    {
        public RAZORCRUDBookContext (DbContextOptions<RAZORCRUDBookContext> options)
            : base(options)
        {
        }

        public DbSet<RAZORCRUD.Models.Book> Book { get; set; }
    }
