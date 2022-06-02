using SalesWebMvc.Models.Entities;
using SalesWebMvc.Models.ValueObjects;
using System;
using System.Linq;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private readonly SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.SalesRecord.Any() ||
                _context.Seller.Any())
            {
                return; //DB has been seeded
            }

            DepartmentEntity d1 = new DepartmentEntity("Computers");
            DepartmentEntity d2 = new DepartmentEntity("Electronics");
            DepartmentEntity d3 = new DepartmentEntity("Fashion");
            DepartmentEntity d4 = new DepartmentEntity("Books");

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.SaveChanges();

            SellerEntity s1 = new SellerEntity("Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            SellerEntity s2 = new SellerEntity("Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            SellerEntity s3 = new SellerEntity("Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            SellerEntity s4 = new SellerEntity("Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            SellerEntity s5 = new SellerEntity("Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            SellerEntity s6 = new SellerEntity("Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SaveChanges();

            SalesRecordEntity r1 = new SalesRecordEntity(new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecordEntity r2 = new SalesRecordEntity(new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecordEntity r3 = new SalesRecordEntity(new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecordEntity r4 = new SalesRecordEntity(new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecordEntity r5 = new SalesRecordEntity(new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecordEntity r6 = new SalesRecordEntity(new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecordEntity r7 = new SalesRecordEntity(new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecordEntity r8 = new SalesRecordEntity(new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecordEntity r9 = new SalesRecordEntity(new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecordEntity r10 = new SalesRecordEntity(new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecordEntity r11 = new SalesRecordEntity(new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecordEntity r12 = new SalesRecordEntity(new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecordEntity r13 = new SalesRecordEntity(new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecordEntity r14 = new SalesRecordEntity(new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecordEntity r15 = new SalesRecordEntity(new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecordEntity r16 = new SalesRecordEntity(new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecordEntity r17 = new SalesRecordEntity(new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecordEntity r18 = new SalesRecordEntity(new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecordEntity r19 = new SalesRecordEntity(new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecordEntity r20 = new SalesRecordEntity(new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecordEntity r21 = new SalesRecordEntity(new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecordEntity r22 = new SalesRecordEntity(new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecordEntity r23 = new SalesRecordEntity(new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecordEntity r24 = new SalesRecordEntity(new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecordEntity r25 = new SalesRecordEntity(new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecordEntity r26 = new SalesRecordEntity(new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecordEntity r27 = new SalesRecordEntity(new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecordEntity r28 = new SalesRecordEntity(new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecordEntity r29 = new SalesRecordEntity(new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecordEntity r30 = new SalesRecordEntity(new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
