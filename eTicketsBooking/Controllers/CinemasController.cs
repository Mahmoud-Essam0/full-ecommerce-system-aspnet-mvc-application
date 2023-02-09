using eTicketsBooking.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketsBooking.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _Context;
        public CinemasController(AppDbContext Context)
        {
            _Context = Context;
        }
        public async Task<IActionResult> Index()
        {
            var cinemasList = await _Context.Cinemas.ToListAsync();
            return View();
        }
    }
}
