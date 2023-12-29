using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);
            if (producer == null)
                return View("NotFound");
            return View(producer);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);
            return View(producer);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.UpdateAsync(Id, producer);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);
            return View(producer);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var producer = await _service.GetByIdAsync(Id);
            if (producer == null)
                return View("NotFound");

            await _service.DeleteAsync(Id);

            return RedirectToAction(nameof(Index)); 
        }
    }
}
