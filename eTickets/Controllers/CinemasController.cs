using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAllAsync();
            return View(allCinemas);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int Id)
        {
            var cinema = await _service.GetByIdAsync(Id);
            if (cinema == null)
                return View("NotFound");
            return View(cinema);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var cinema = await _service.GetByIdAsync(Id);
            return View(cinema);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(Id, cinema);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var cinema = await _service.GetByIdAsync(Id);
            return View(cinema);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var cinema = await _service.GetByIdAsync(Id);
            if (cinema == null)
                return View("NotFound");

            await _service.DeleteAsync(Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
