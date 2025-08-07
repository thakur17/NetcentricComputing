using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcProj.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }

        [Column(TypeName = "nvarchar (40)")]
        [StringLength(40)]
        [Required]
        public string CompanyName { get; set; } = null!;

        [Column(TypeName = "nvarchar (30)")]
        [StringLength(30)]
        public string? Country { get; set; }

        [Column(TypeName = "nvarchar (24)")]
        [StringLength(24)]
        public string? Phone { get; set; }


    }
}
