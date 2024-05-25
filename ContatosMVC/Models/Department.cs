namespace ContatosMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
    }
}
