using CaoNguyenVu_0162_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CaoNguyenVu_0162_CodeFirst.data_access
{
    public class InforCompanyDBContext : DbContext
    {
        public InforCompanyDBContext()
        {
        }

        public InforCompanyDBContext(DbContextOptions<InforCompanyDBContext> options) : base(options)
        { }

        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}