using Microsoft.EntityFrameworkCore;
using TraversalAPI.DAL.Entities;

namespace TraversalAPI.DAL.Context
{
    public class VisitorContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-33VDDOP\\SQLEXPRESS17;initial catalog=TraversalAPIdb;integrated security=true;");
        }
        public DbSet<Visitor>Visitors { get; set; }
    }
}
