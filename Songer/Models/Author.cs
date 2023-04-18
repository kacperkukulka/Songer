namespace Songer.Models {
    public abstract class Author {
        public int Id { get; set; }

        public virtual List<Album> Albums { get; set; } = new List<Album>();
        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
