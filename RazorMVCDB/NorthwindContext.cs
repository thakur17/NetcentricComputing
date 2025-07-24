using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RazorWithDB.NorthwindDB
{
    public class NorthwindContext : DbContext
    {

        public NorthwindContext()
        {
                
        }
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Supplier> Suppliers { get; set; }



    }


}
