

using Entities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // Product tablosunu temsil eden DbSet özelliği
        public DbSet<Product> Products { get; set; }

    }
}
