using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB já foi populado.
            }

            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletrônicos");
            Department d3 = new Department(3, "Roupas");
            Department d4 = new Department(4, "Livros");

            Seller s1 = new Seller(1, "Jhon Snow", "jhon@gmail.com", new DateTime(1998, 4, 1), 7200.0, d1);
            Seller s2 = new Seller(2, "Thomas Shelby", "ths@gmail.com", new DateTime(1998, 4, 1), 150000.0, d2);
            Seller s3 = new Seller(3, "Homer Simpson", "homer@gmail.com", new DateTime(1998, 4, 1), 3700.0, d1);
            Seller s4 = new Seller(4, "Amy Winehouse", "amy@gmail.com", new DateTime(1998, 4, 1), 4300.0, d2);
            Seller s5 = new Seller(5, "Naruto Uzumaki", "naruto@gmail.com", new DateTime(1998, 4, 1), 93000.0, d3);
            Seller s6 = new Seller(6, "Kakashi Hatake", "kakashi@gmail.com", new DateTime(1998, 4, 1), 5300.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2022, 1, 1), 50.0, SaleStatus.Pending, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2022, 1, 1), 50.0, SaleStatus.Pending, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2022, 1, 1), 50.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2022, 1, 1), 50.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2022, 1, 1), 50.0, SaleStatus.Canceled, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2022, 1, 1), 50.0, SaleStatus.Canceled, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2022, 1, 1), 150.0, SaleStatus.Pending, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2022, 1, 1), 150.0, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2022, 1, 1), 150.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2022, 1, 1), 150.0, SaleStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2022, 1, 1), 150.0, SaleStatus.Canceled, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2022, 1, 1), 150.0, SaleStatus.Canceled, s6);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12);

            _context.SaveChanges();
        }
    }
}