using System;
using System.Collections.Generic;

namespace SalesWebMvc.Models.Entities
{
    public class SellerEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public DepartmentEntity department { get; set; }
        public virtual ICollection<SalesRecordEntity> SalesRecords { get; set; } = new List<SalesRecordEntity>();

        public SellerEntity()
        {
        }

        public SellerEntity
        (
            string name, 
            string email, 
            DateTime birthDate, 
            double baseSalary, 
            DepartmentEntity department,
            int id
        ) : base(id)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            this.department = department;
        }
    }
}
