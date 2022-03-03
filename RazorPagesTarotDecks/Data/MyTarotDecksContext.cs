using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTarotDecks.Models;

    public class MyTarotDecksContext : DbContext
    {
        public MyTarotDecksContext (DbContextOptions<MyTarotDecksContext> options)
            : base(options)
        {
        }

        public DbSet<MyTarotDecks.Models.TarotCards> TarotCards { get; set; }
    }
