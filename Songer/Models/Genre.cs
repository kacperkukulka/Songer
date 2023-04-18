namespace Songer.Models {
    public class Genre {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Song> Songs { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
