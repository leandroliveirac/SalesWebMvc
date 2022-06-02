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

        public IEnumerable<SellerEntity> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
