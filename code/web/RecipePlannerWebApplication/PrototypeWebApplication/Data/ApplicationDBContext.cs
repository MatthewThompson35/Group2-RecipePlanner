using Microsoft.EntityFrameworkCore;
using PrototypeWebApplication.Models;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace PrototypeWebApplication.Data
{
    public class ApplicationDBContext : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Names> Names { get; set; }

        public ApplicationDBContext(DbContextOptions options) : base(options) 
        {
        
        }
    }
}
