using Microsoft.EntityFrameworkCore;

namespace WebApplication18.Models.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Userinfo> userinfos { get; set; }
        
    }
}
