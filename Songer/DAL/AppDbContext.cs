using Microsoft.EntityFrameworkCore;
using Songer.Models;

namespace Songer.DAL {
    public class AppDbContext: DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Album_Rating> User_Album_Ratings { get; set; }
        public DbSet<User_Song_Rating> User_Song_Ratings { get; set; }
    }
}
