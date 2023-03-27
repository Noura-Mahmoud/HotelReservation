using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Start.Entites;

namespace Start.Context
{
    public class HotelContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=Hotel;Integrated Security=true;Encrypt=false");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
    }
}
