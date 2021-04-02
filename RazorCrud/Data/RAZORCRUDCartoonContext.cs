using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RAZORCRUD.Models;

    public class RAZORCRUDCartoonContext : DbContext
    {
        public RAZORCRUDCartoonContext (DbContextOptions<RAZORCRUDCartoonContext> options)
            : base(options)
        {
        }

        public DbSet<RAZORCRUD.Models.Cartoon> Cartoon { get; set; }
    }
