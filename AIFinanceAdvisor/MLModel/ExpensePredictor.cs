using System;
using System.Collections.Generic;
using System.Linq;
using AIFinanceAdvisor.Models;

namespace AIFinanceAdvisor.MLModel
{
    public class ExpensePredictor
    {
        public string GetBudgetAdvice(List<Expense> expenses)
        {
            if (expenses == null || expenses.Count == 0)
                return "No data available yet.";

            decimal totalSpent = expenses.Sum(e => e.Amount);
            decimal avg = expenses.Average(e => e.Amount);

            string advice = $"💰 Total Spent: ₹{totalSpent} | Average Expense: ₹{avg:F2}\n";

            if (totalSpent > 10000)
                advice += "⚠️ You're spending too much this month! Try cutting non-essentials.";
            else if (totalSpent > 5000)
                advice += "🟡 Moderate spending. Review categories with higher costs.";
            else
                advice += "🟢 Great! Your expenses are under control.";

            return advice;
        }
    }
}
