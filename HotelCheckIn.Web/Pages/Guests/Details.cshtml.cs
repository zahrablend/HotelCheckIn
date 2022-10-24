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
    public class DetailsModel : PageModel
    {
        private readonly HotelCheckIn.Web.Data.HotelCheckInWebContext _context;

        public DetailsModel(HotelCheckIn.Web.Data.HotelCheckInWebContext context)
        {
            _context = context;
        }

      public Guest Guest { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Guest == null)
            {
                return NotFound();
            }

            var guest = await _context.Guest.FirstOrDefaultAsync(m => m.Id == id);
            if (guest == null)
            {
                return NotFound();
            }
            else 
            {
                Guest = guest;
            }
            return Page();
        }
    }
}
