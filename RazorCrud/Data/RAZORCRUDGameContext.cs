using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RAZORCRUD.Models;

    public class RAZORCRUDGameContext : DbContext
    {
        public RAZORCRUDGameContext (DbContextOptions<RAZORCRUDGameContext> options)
            : base(options)
        {
        }

        public DbSet<RAZORCRUD.Models.Game> Game { get; set; }
    }
