namespace Kausar.Data.Entity
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
        public int CustomerIdentificationId { get; set; }
        public CustomerIdentification CustomerIdentification { get; set; }
        public List<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
    }
}
