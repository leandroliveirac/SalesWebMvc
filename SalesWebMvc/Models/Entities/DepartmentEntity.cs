using System.Collections.Generic;

namespace SalesWebMvc.Models.Entities
{
    public class DepartmentEntity : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<SellerEntity> Sellers { get; set; } = new List<SellerEntity>();

        public DepartmentEntity()
        {
        }

        public DepartmentEntity(string name, int id) : base(id)
        {
            Name = name;            
        }
    }
}
