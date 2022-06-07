using SalesWebMvc.Data;
using SalesWebMvc.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public ICollection<DepartmentEntity> FindAll()
        {
            return _context.Department.ToList();
        }
    }
}
