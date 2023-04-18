using System.ComponentModel.DataAnnotations.Schema;

namespace Songer.Models {
    [Table("Musicians")]
    public class Musician : Author {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? StageName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
