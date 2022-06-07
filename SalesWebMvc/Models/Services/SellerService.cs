using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public SellerEntity FindById(int id)
        {
            return _context.Seller
                            .Include(p => p.Department)
                            .FirstOrDefault(p => p.Id.Equals(id));
        }

        public IEnumerable<SellerEntity> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(SellerEntity seller)
        {
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.FirstOrDefault(p => p.Id.Equals(id));
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
