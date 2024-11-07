using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Zorunludur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fiyat Zorunludur")]
        public string Price { get; set; }

        [AllowNull]
        public string? Description { get; set; } 
    }
}
