using SalesWebMvc.Models.ValueObjects;
using System;

namespace SalesWebMvc.Models.Entities
{
    public class SalesRecordEntity : BaseEntity
    {
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public SellerEntity Seller { get; set; }

        public SalesRecordEntity()
        {
        }

        public SalesRecordEntity
        (
            DateTime date, 
            double amount, 
            SaleStatus status, 
            SellerEntity seller,
            int id
        ) : base(id)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
