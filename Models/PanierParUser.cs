namespace tp5.Models
{
    public class PanierParUser
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string UserID { get; set; } = string.Empty;
        public string ProduitId { get; set; } = string.Empty;
        public List<Produit> Produits { get; set; } = new();
    }
}
