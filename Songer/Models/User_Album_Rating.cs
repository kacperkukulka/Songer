namespace Songer.Models {
    public class User_Album_Rating {
        public int Id { get; set; }
        public int Rating { get; set; }

        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
