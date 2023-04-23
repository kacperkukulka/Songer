using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.IdentityModel.Tokens;
using Songer.Models;
using Songer.Services;
using Songer.ViewModels;

namespace Songer.Controllers {
    public class GenresController : Controller {
        private readonly IGenresService _service;
        public GenresController(IGenresService service) {
            _service = service;
        }

        public async Task<IActionResult> Index(string newName, int id) {
            var genre = new Genre();
            var genres = await _service.GetAllAsync();
            var vm = new GenresIndexVM { 
                Genres = genres,
            };
            if (id == 0) {
                vm.NewGenre = new Genre { Name = newName };
                vm.EditGenre = new Genre();
            }
            else {
                vm.NewGenre = new Genre();
                vm.EditGenre = new Genre { Id = id, Name = newName };
            }
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Genre NewGenre) {
            var ms = ModelState;
            if (!ModelState.IsValid) {
                TempData["ErrorAdd"] = String.Join(", ", ModelState["Name"]!.Errors.Select(v => v.ErrorMessage));
                return RedirectToAction(nameof(Index), new { newName = NewGenre.Name });
            }
            await _service.AddAsync(NewGenre);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id) {
            var genre = await _service.GetAsync(id);
            if (genre == null) {
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index), new { newName = genre.Name, id = genre.Id });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Genre NewGenre) {
            if (!ModelState.IsValid) {
                TempData["ErrorEdit"] = String.Join(", ", ModelState["Name"]!.Errors.Select(v => v.ErrorMessage));
                return RedirectToAction(nameof(Index), new { newName = NewGenre.Name, id = NewGenre.Id } );
            }
            await _service.UpdateAsync(NewGenre);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id) {
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
