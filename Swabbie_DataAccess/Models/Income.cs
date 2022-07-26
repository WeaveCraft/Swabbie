using Swabbie_DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

namespace Swabbie_DataAccess.Models
{
    public class Income
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public ExpenseCat Category { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public TransactionCat TranscationType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
