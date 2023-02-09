using eTicketsBooking.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketsBooking.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _Context;
        public MoviesController(AppDbContext Context)
        {
            _Context = Context;
        }
        public async Task<IActionResult> Index()
        {
            var moviesList = await _Context.Movies.ToListAsync();
            return View();
        }
    }
}
