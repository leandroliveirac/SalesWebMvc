using SalesWebMvc.Models.ValueObjects;
using System;

namespace SalesWebMvc.Models.Entities
{
    public class SalesRecordEntity : BaseEntity
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
    }
}
