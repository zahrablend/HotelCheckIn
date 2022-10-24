using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelCheckIn.Data.Models;

namespace HotelCheckIn.Web.Data
{
    public class HotelCheckInWebContext : DbContext
    {
        public HotelCheckInWebContext (DbContextOptions<HotelCheckInWebContext> options)
            : base(options)
        {
        }

        public DbSet<HotelCheckIn.Data.Models.Room> Room { get; set; } = default!;

        public DbSet<HotelCheckIn.Data.Models.Guest> Guest { get; set; }

        public DbSet<HotelCheckIn.Data.Models.Service> Service { get; set; }
    }
}
