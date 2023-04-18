using System.ComponentModel.DataAnnotations.Schema;

namespace Songer.Models {
    [Table("Bands")]
    public class Band : Author{
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
