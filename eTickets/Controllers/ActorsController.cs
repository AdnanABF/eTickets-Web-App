using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualBasic;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAllAsync();
            return View(allActors);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int Id)
        {
            var actorDetails = await _service.GetByIdAsync(Id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        public async Task<IActionResult> Edit(int Id)
        {
            var actorDetails = await _service.GetByIdAsync(Id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(Id, actor);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var actorDetails = await _service.GetByIdAsync(Id);
            if (actorDetails == null)
                return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var actorDetails = await _service.GetByIdAsync(Id);
            if (actorDetails == null)
                return View("NotFound");

            await _service.DeleteAsync(Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
