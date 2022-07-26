using Swabbie_DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swabbie_Models.DTO
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public ExpenseCat Category { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public TransactionCat TranscationType { get; set; }
    }
}
