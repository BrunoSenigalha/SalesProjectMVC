/*Essa classe tem como função adicionar o obj do tipo Seller no banco de dados*/

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models.Services.Exceptions;
using System.Data;

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
            var sellerById = _context.Sellers.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);

            if (sellerById is null)
                throw new NotFoundException("Id not found");

            return sellerById;
        }

        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);

            if (obj is not null)
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if (!_context.Sellers.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }
    }
}
