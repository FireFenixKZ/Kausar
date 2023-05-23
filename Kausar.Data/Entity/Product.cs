namespace Kausar.Data.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Unit { get; set; }
        public HashSet<Image> Images { get; set; }
        public bool Published { get; set; }
        public decimal Price { get; set; }
        public string Details { get; set; }
    }
}
