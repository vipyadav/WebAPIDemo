using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VipWeb.Model;

namespace VipWeb.Data
{
    public class VipDbContext : DbContext
    {
        public VipDbContext(DbContextOptions<VipDbContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
