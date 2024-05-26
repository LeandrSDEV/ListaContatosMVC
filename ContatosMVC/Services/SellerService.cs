using ContatosMVC.Data;
using ContatosMVC.Models;

namespace ContatosMVC.Services
{
    public class SellerService
    {
        private readonly ContatosMVCContext _context;

        public SellerService(ContatosMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj)
        {         
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
