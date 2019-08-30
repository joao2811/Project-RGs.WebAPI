using Microsoft.EntityFrameworkCore;
using Projeto1.Models;

namespace Projeto1.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<RG> RGs {get;set;}
    }
}