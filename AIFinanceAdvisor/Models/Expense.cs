using System.ComponentModel.DataAnnotations;

namespace AIFinanceAdvisor.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
