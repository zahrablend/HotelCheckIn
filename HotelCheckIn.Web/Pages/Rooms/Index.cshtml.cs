using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelCheckIn.Data.Models;
using HotelCheckIn.Web.Data;

namespace HotelCheckIn.Web.Pages.Rooms
{
    public class RoomModel : PageModel
    {
        private readonly HotelCheckIn.Web.Data.HotelCheckInWebContext _context;

        public RoomModel(HotelCheckIn.Web.Data.HotelCheckInWebContext context)
        {
            _context = context;
        }

        public IList<Room> Room { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Room != null)
            {
                Room = await _context.Room.ToListAsync();
            }
        }
    }
}
