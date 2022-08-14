using Swabbie_DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

namespace Swabbie_Models.DTO.Transactions
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? TransactionDate { get; set; }
        [Required]
        public ExpenseCat Category { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public TransactionCat TransactionType { get; set; }
        [Required]
        public CurrencyCat CurrencyType { get; set; }
    }
}
