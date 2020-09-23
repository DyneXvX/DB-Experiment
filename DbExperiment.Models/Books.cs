using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbExperiment.Models
{
    public class Books
    {
        public int Id { get; set; }

        [Required] public string Title { get; set; }
        [Required] public int ISBN { get; set; }
        [Required] public string Category { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}