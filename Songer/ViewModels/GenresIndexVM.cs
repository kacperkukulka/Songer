using Songer.Models;
using System.ComponentModel.DataAnnotations;

namespace Songer.ViewModels {
    public class GenresIndexVM {
        public IEnumerable<Genre> Genres { get; set; }
        public Genre NewGenre { get; set; }
        public Genre EditGenre { get; set; }
    }
}
