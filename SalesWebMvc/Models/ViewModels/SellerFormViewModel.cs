using SalesWebMvc.Models.Entities;
using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public SellerEntity Seller { get; set; }
        public ICollection<DepartmentEntity> Departments { get; set; } = new List<DepartmentEntity>();
    }
}
