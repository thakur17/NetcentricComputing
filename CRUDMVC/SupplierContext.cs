using Microsoft.EntityFrameworkCore;
using mvcProj.Models;
using System.Collections.Generic;

namespace mvcProj.Data
{
    public class SupplierContext : DbContext
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
