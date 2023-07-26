using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace MoesPizzeriaAPI.Models
{
    public class ItemModel
    {

        [Key]
        public int ItemId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? ItemName { get; set; }
        [Column(TypeName = "nvarchar(300)")]
        public string? ItemDescription { get; set; }
        [Column(TypeName = "decimal(4,2)")]
        public decimal ItemPrice { get; set; }
    }
}
