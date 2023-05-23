using System.ComponentModel.DataAnnotations.Schema;

namespace Kausar.Data.Entity
{
    public class BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Guid Version { get; set; }
    }
}
