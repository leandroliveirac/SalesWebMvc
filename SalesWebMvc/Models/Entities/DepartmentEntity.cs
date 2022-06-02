using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models.Entities
{
    public class DepartmentEntity : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<SellerEntity> Sellers { get; set; } = new List<SellerEntity>();

        public DepartmentEntity()
        {
        }

        public DepartmentEntity(string name)
        {
            Name = name;            
        }

        public void AddSeller(SellerEntity seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(Seller => Seller.TotalSales(initial, final));
        }
    }
}
