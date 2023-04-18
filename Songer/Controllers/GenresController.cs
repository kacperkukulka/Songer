using Microsoft.AspNetCore.Mvc;
using Songer.Models;
using Songer.Services;
using Songer.ViewModels;

namespace Songer.Controllers {
    public class GenresController : Controller {
        private readonly IGenresService _service;
        public GenresController(IGenresService service) {
            _service = service;
        }

        public async Task<IActionResult> Index() {
            var genres = await _service.GetAllAsync();
            var vm = new GenresIndexVM {
                Genres = genres
            };

            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Genre genre) {
            await _service.AddAsync(genre);
            return RedirectToAction("Index");
        }
    }
}
