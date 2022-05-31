using System;

namespace SalesWebMvc.Models.Entities
{
    public class SallerEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
    }
}
