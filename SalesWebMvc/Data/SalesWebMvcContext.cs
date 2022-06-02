using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models.Entities;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) 
            : base(options)
        {
        }

        public DbSet<DepartmentEntity> Department { get; set; }
        public DbSet<SellerEntity> Seller { get; set; }
        public DbSet<SalesRecordEntity> SalesRecord { get; set; }
    }
}
