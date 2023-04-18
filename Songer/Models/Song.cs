namespace Songer.Models {
    public class Song {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public int? AlbumId { get; set; }
        public virtual Album? Album { get; set; }
        public virtual List<User_Song_Rating> User_Song_Ratings { get; set; }
    }
}
