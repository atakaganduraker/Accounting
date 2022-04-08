using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8GED7AK\SQLEXPRESS01;Database=AccountingDb;Trusted_Connection=true");
        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<CaseRatio> CaseRatios { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationCase> OperationCases { get; set; }
        public DbSet<OperationDetail> OperationDetails { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Ratio> Ratios { get; set; }
    }
}
