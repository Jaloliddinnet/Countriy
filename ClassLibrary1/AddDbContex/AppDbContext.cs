using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.data.Models;

namespace Web.data.AddDbContex
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Qita>  Qita { get; set; }
        public DbSet<Davlatlar> Davlatlar { get; set;}
        public DbSet<Shaharlar> Shaharlar { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Qita>(p => p.
            HasMany(p => p.Davlat).
            WithOne(davlat => davlat.qita).
            HasForeignKey(Davlat => Davlat.Qita_Id));

            modelBuilder.Entity<Davlatlar>(p => p.
            HasMany(p => p.shahar).
            WithOne(shahar => shahar.Davlat).
            HasForeignKey(shahar => shahar.Davlat_id));

            base.OnModelCreating(modelBuilder);
        }

    }
}
