using Songer.Base;
using Songer.DAL;
using Songer.Models;

namespace Songer.Services {
    public class GenresService : BaseRepository<Genre>, IGenresService {
        public GenresService(AppDbContext context): base(context) { }
    }
}
