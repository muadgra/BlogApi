using BlogApiChallange.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApiChallange.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Paylasim> Paylasimlar { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }

    }
}