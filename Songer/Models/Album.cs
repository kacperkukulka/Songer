namespace Songer.Models {
    public class Album {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<Song> Songs { get; set; }
        public virtual List<User_Album_Rating> User_Album_Ratings { get; set; }
    }
}
