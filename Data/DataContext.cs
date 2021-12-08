using ForWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ForWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Test> Tests { get; set;}
        
    }
}