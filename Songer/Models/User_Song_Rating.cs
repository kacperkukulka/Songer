namespace Songer.Models {
    public class User_Song_Rating {
        public int Id { get; set; }
        public int Rating { get; set; }

        public int SongId { get; set; }
        public virtual Song Song { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
