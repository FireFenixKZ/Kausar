using System.Numerics;

namespace Kausar.Data.Entity
{
    public class CustomerIdentification : BaseEntity
    {
        public string IdentificationType { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Iin { get; set; }
        public string DocNumber { get; set; }
    }
}
