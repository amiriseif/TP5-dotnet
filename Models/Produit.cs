namespace tp5.Models
{
    public class Produit
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();  // TEXT compatible SQL Server
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
