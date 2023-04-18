using Songer.Models;

namespace Songer.ViewModels {
    public class GenresIndexVM {
        public IEnumerable<Genre> Genres { get; set; }
        public Genre NewGenre { get; set; }
        public int? EditGenre { get; set; }
    }
}
