using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models.Entities
{
    public class SellerEntity : BaseEntity
    {
        [Required(ErrorMessage = "Obrigatório")]
        public string Name { get; set; }
        
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name ="Birth Date")]
        public DateTime BirthDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "Base Salary")]
        public double BaseSalary { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public virtual DepartmentEntity Department { get; set; }
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
            DepartmentEntity department
        )
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecordEntity salesRecord)
        {
            SalesRecords.Add(salesRecord);
        }

        public void RemoveSales(SalesRecordEntity salesRecord)
        {
            SalesRecords.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesRecords.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
