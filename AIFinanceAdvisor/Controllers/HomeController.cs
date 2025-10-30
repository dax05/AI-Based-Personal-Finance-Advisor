using Microsoft.AspNetCore.Mvc;
using AIFinanceAdvisor.Models;
using AIFinanceAdvisor.MLModel;
using System.Collections.Generic;
using System.Linq;

namespace AIFinanceAdvisor.Controllers
{
    public class HomeController : Controller
    {
        private static List<Expense> Expenses = new();
        private readonly ExpensePredictor _predictor = new();

        // 🏠 Home Page - Add and View Expenses
        public IActionResult Index()
        {
            ViewBag.Advice = _predictor.GetBudgetAdvice(Expenses);
            return View(Expenses);
        }

        [HttpPost]
        public IActionResult AddExpense(string category, decimal amount)
        {
            if (!string.IsNullOrEmpty(category) && amount > 0)
            {
                Expenses.Add(new Expense
                {
                    Category = category,
                    Amount = amount,
                    Date = DateTime.Now
                });
            }
            return RedirectToAction("Index");
        }

        // 📊 Dashboard Page
        public IActionResult Dashboard()
        {
            var grouped = Expenses
                .GroupBy(e => e.Category)
                .Select(g => new { Category = g.Key, Total = g.Sum(x => x.Amount) })
                .ToList();

            ViewBag.Total = Expenses.Sum(e => e.Amount);
            ViewBag.Data = grouped;
            return View();
        }

        // 📅 Expense History Page
        public IActionResult History()
        {
            return View(Expenses.OrderByDescending(e => e.Date).ToList());
        }

        // 🧠 AI Insights Page
        public IActionResult Insights()
        {
            ViewBag.Advice = _predictor.GetBudgetAdvice(Expenses);
            return View();
        }
    }
}
