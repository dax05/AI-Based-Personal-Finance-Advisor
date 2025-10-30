# AI-Based Personal Finance Advisor

## Description
The **AI-Based Personal Finance Advisor** is a .NET 8 MVC web application that helps users track daily expenses, visualize spending patterns, and receive AI-driven financial insights.  
It uses **ASP.NET Core MVC**, **Entity Framework Core (SQLite)**, and **ML.NET** to offer an interactive and intelligent budgeting experience.

---

## Technologies Used
- **.NET 8.0** (ASP.NET Core MVC)
- **Entity Framework Core (SQLite)** for lightweight data storage
- **ML.NET** for simple AI-based budget predictions
- **Bootstrap 5** for responsive front-end design
- **C#** for backend logic
- **Chart.js** (optional) for graphical data visualization

---

## ⚙️ Installation and Setup (Windows 11)

### 🧩 Prerequisites
Ensure the following tools are installed:
| Tool | Description | Link |
|------|--------------|------|
| .NET SDK | Backend framework | https://dotnet.microsoft.com/en-us/download/dotnet |
| Visual Studio Code / Visual Studio 2022 | Code editor / IDE | https://code.visualstudio.com/ |
| Git | Version control | https://git-scm.com/downloads |
| SQLite | Lightweight database | Built into EF Core |

Verify installations:
```bash
dotnet --version
git --version
```

---

### 🏗️ Project Setup Commands

```bash
# Create project folder
mkdir AI_Finance_Advisor
cd AI_Finance_Advisor

# Create ASP.NET Core MVC project
dotnet new mvc -n AIFinanceAdvisor
cd AIFinanceAdvisor
```

---

### 📦 Install Required NuGet Packages

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.ML
```

---

### 🗂 Folder Structure

```
AIFinanceAdvisor/
│
├── Controllers/
│   └── HomeController.cs
│
├── Models/
│   └── Expense.cs
│
├── MLModel/
│   └── ExpensePredictor.cs
│
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── Dashboard.cshtml
│   │   ├── History.cshtml
│   │   └── Insights.cshtml
│
├── wwwroot/
│   ├── css/
│   ├── js/
│
├── appsettings.json
├── Program.cs
├── README.md
└── AIFinanceAdvisor.csproj
```

---

## 💾 Project Overview

### **1️⃣ Models**
#### `Models/Expense.cs`
Defines the structure for an expense entry containing Category, Amount, and Date.

### **2️⃣ ML Model**
#### `MLModel/ExpensePredictor.cs`
Implements a simple AI logic (rule-based) that analyzes total and average expenses to generate financial advice.

### **3️⃣ Controllers**
#### `HomeController.cs`
Handles routes for:
- Home (Add & View Expenses)
- Dashboard (Spending Summary)
- History (Expense Table)
- AI Insights (Smart Advice)

### **4️⃣ Views**
- **Index.cshtml** → Add and display expenses
- **Dashboard.cshtml** → View summarized data (with charts)
- **History.cshtml** → See all past expenses
- **Insights.cshtml** → Read AI advice

### **5️⃣ Optional Enhancement**
Add **Chart.js** in the Dashboard page for interactive pie/bar charts.

---

## 🚀 Run the Project

```bash
dotnet build
dotnet run
```

Then open your browser at:
👉 http://localhost:5121

---

## 📊 Features
✅ Add daily expenses by category  
✅ View total and average monthly spending  
✅ Receive AI-generated budgeting advice  
✅ View category-wise summary in Dashboard  
✅ Browse detailed expense history  
✅ Responsive UI using Bootstrap  

---

## 🧠 How AI Works
The `ExpensePredictor` uses a simple rule-based system:  
- If total > ₹10,000 → ⚠️ High Spending Alert  
- If total > ₹5,000 → 🟡 Moderate Spending  
- If total < ₹5,000 → 🟢 Healthy Budget  

You can extend this to use **ML.NET Regression** for real prediction models later.

---

---

## 📜 License
MIT License © 2025 Daksh Punmiya

---

## 👩‍💻 Author
**Daksh Punmiya**  

