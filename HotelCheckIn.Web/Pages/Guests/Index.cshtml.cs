using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelCheckIn.Data.Models;
using HotelCheckIn.Web.Data;

namespace HotelCheckIn.Web.Pages.Guests
{
    public class GuestModel : PageModel
    {
        private readonly HotelCheckIn.Web.Data.HotelCheckInWebContext _context;

        public GuestModel(HotelCheckIn.Web.Data.HotelCheckInWebContext context)
        {
            _context = context;
        }

        public IList<Guest> Guest { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Guest != null)
            {
                Guest = await _context.Guest.ToListAsync();
            }
        }
    }
}
