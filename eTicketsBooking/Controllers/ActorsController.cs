using eTicketsBooking.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketsBooking.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _Context;
        public ActorsController(AppDbContext Context)
        {
            _Context = Context;
        }
        public async Task<IActionResult> Index()
        {   
            var actorsList = await _Context.Actors.ToListAsync();
            return View();
        }
    }
}
