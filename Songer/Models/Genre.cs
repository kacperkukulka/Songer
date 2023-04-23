using Songer.Base;
using System.ComponentModel.DataAnnotations;

namespace Songer.Models {
    public class Genre : IBaseModel {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50,MinimumLength = 2, ErrorMessage = "Genre has to be between 2 and 50 chars")]
        public string Name { get; set; }

        public virtual List<Song> Songs { get; set; } = new List<Song>();
        public virtual List<Album> Albums { get; set; } = new List<Album>();
    }
}
