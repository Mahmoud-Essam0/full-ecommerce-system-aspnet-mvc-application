using eTicketsBooking.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicketsBooking.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _Context;
        public ProducersController(AppDbContext Context)
        {
            _Context = Context;
        }
        public async Task<IActionResult> Index()
        {
            var producersList = await _Context.Producers.ToListAsync();
            return View();
        }
    }
}
