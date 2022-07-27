using Swabbie_DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

namespace Swabbie_DataAccess.Transactions
{
    public class Saving
    {
        [Key]
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public SavingsCat Category { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
