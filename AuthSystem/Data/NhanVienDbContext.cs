using AuthSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthSystem.Data
{
    public class NhanVienDbContext:DbContext
    {
        public NhanVienDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<NhanVien> NhanViens { get; set;}
    }
    

}
