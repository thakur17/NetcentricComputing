using Microsoft.EntityFrameworkCore;

namespace wesqlite.Model
{
    public class SupplierContext:DbContext
    {
        public SupplierContext()
        {

        }
        public SupplierContext(DbContextOptions<SupplierContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Supplier> Suppliers { get; set; }

    }
}
