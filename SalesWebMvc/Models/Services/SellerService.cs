/*Essa classe tem como função adicionar o obj do tipo Seller no banco de dados*/

using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;

namespace SalesWebMvc.Models.Services
{
    public class SellerService(SalesWebMvcContext context)
    {
        private readonly SalesWebMvcContext _context = context;

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int? id)
        {
            return _context.Sellers.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }
    }
}
