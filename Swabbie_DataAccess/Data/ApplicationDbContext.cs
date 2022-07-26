using Microsoft.EntityFrameworkCore;
using Swabbie_DataAccess.Models;

namespace Swabbie_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Saving> Savings { get; set; } 
        public DbSet<Income> Incomes { get; set; } 
        public DbSet<Expense> Expenses { get; set; } 
    }
}
