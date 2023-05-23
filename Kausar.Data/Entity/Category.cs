namespace Kausar.Data.Entity
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public string Icon { get; set; }
        public int ParentId { get; set; }
        public int Position { get; set; }
        public List<Product> Products { get; set; }
    }
}
