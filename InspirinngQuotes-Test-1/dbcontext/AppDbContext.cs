using InspirinngQuotes_Test_1.Models;
using Microsoft.EntityFrameworkCore;

namespace InspirinngQuotes_Test_1.dbcontext
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data source=DataBase\AppDataBase.db");
        public DbSet<Tags> tags {  get; set; }
        
    }
}
