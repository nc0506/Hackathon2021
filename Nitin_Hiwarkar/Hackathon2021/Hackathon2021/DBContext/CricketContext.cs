using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon2021.Model;

namespace Hackathon2021.DBContext
{
    public class CricketContext:DbContext
    {
        public CricketContext(DbContextOptions<CricketContext> options) : base(options)
        {
        }
       
        public DbSet<Data> Data { get; set; }

        public DbSet<Cricketer> Cricketer { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Teams> teams { get; set; }
        public DbSet<Season> Season { get; set; }
        public DbSet<Venue> Venue { get; set; }
        public DbSet<wickettype> wickettype { get; set; }
        


    }
}
