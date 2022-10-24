using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelCheckIn.Data.Models;
using HotelCheckIn.Web.Data;

namespace HotelCheckIn.Web.Pages.Services
{
    public class DetailsModel : PageModel
    {
        private readonly HotelCheckIn.Web.Data.HotelCheckInWebContext _context;

        public DetailsModel(HotelCheckIn.Web.Data.HotelCheckInWebContext context)
        {
            _context = context;
        }

      public Service Service { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Service == null)
            {
                return NotFound();
            }

            var service = await _context.Service.FirstOrDefaultAsync(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }
            else 
            {
                Service = service;
            }
            return Page();
        }
    }
}
