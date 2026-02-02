namespace ProductsAPI.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public string? ProductLabel { get; set; }
        public string? Contractor { get; set; }
        public int? Quantity { get; set; }
    }
}
