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
    public class ServiceModel : PageModel
    {
        private readonly HotelCheckIn.Web.Data.HotelCheckInWebContext _context;

        public ServiceModel(HotelCheckIn.Web.Data.HotelCheckInWebContext context)
        {
            _context = context;
        }

        public IList<Service> Service { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Service != null)
            {
                Service = await _context.Service.ToListAsync();
            }
        }
    }
}
