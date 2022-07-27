using Swabbie_DataAccess.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Swabbie_DataAccess.Transactions
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public ExpenseCat Category { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public TransactionCat TransactionType { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
