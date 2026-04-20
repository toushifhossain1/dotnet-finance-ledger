# Finance Ledger API

> 🚧 Work in Progress — Building a full ERP-style finance module using .NET

A .NET Web API implementing core financial and accounting principles, including double-entry bookkeeping, journal processing, and accounts receivable management.

This project simulates a real-world ERP finance module, focusing on business logic, data integrity, and clean architecture.

---

## 🚀 Features

* 📘 Chart of Accounts (Asset, Liability, Income, Expense)
* 🔁 Double-entry Journal System (Debit = Credit validation)
* 🧾 Invoice Management (Accounts Receivable)
* 💳 Payment Processing with validation (no overpayment)
* 🔗 Automatic financial tracking via journal entries
* 🧠 Business rule enforcement for financial integrity

---

## 🏗️ Architecture

The project follows a layered architecture:

```
/Controllers   → API layer  
/Services      → Business logic  
/Data          → Database context (EF Core)  
/Models        → Domain entities  
```

This structure reflects real-world backend and ERP system design.

---

## 🧠 Core Concepts Implemented

* Double-entry accounting system
* Separation of JournalEntry and JournalLine
* Financial validation rules:

  * Total Debit = Total Credit
  * No overpayment allowed
  * Transaction integrity enforcement
* Domain-driven thinking for finance systems

---

## 🛠️ Tech Stack

* C#
* .NET (ASP.NET Core Web API)
* Entity Framework Core
* SQL Server / SQLite (configurable)
* Swagger (API testing)

---

## 📌 Key Modules

### 🔹 Accounts

Defines financial accounts categorized by type (Asset, Liability, etc.)

### 🔹 Journal Entries

Core accounting engine supporting multi-line transactions

### 🔹 Invoices

Tracks customer receivables

### 🔹 Payments

Processes payments and updates receivable balances

---

## ⚙️ Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/your-username/finance-ledger-api.git
cd finance-ledger-api
```

---

## 🗄️ Database Setup

This project uses Entity Framework Core with migrations.

To create the database:

```bash
dotnet ef database update

### 2. Run the application

```bash
dotnet run
```

---

### 3. Open Swagger

```
http://localhost:xxxx/swagger
```

---

## 🔒 Business Rules

* Journal entries must be balanced
* Each journal line must be either debit or credit
* Payments cannot exceed invoice due
* Financial data integrity is enforced at service level

---

## 📈 Future Improvements

* Trial Balance & Financial Reports
* Authentication & Role Management
* Multi-currency support
* Integration with ERP systems (e.g., Business Central)
* Advanced validation and audit logs

---

## 👤 Author

**Toushif Hossain**
Software Engineering | ERP | Finance Systems | Backend Development
