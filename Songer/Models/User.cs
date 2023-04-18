namespace Songer.Models {
    public class User {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual List<User_Album_Rating> AlbumRatings { get; set; }
        public virtual List<User_Song_Rating> SongRatings { get; set; }
    }
}
