using Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace API.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SinhVien> sinhViens { get; set; }
    }
}
