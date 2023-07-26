using Microsoft.EntityFrameworkCore;

namespace MoesPizzeriaAPI.Models
{
    public class ItemDetailContext : DbContext
    {
        public ItemDetailContext(DbContextOptions<ItemDetailContext> options) : base (options)
        {
            
        }

        public DbSet<ItemModel> AppetizerMenu { get; set; }
    }
}
