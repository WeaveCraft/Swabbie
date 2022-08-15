using Swabbie_DataAccess.Enums;
using System.ComponentModel.DataAnnotations;

namespace Swabbie_Models.DTO.Transactions
{
    public class SavingDTO
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        [Required]
        public SavingsCat Category { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string? Description { get; set; }
    }
}
