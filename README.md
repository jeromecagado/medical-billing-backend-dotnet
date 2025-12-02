# 🏥 Medical Billing Backend (ASP.NET Core 8 + EF Core + SQL Server)

A fully functional medical billing backend system built with **ASP.NET Core Web API**, **Entity Framework Core**, **SQL Server**, **AutoMapper**, **FluentValidation**, and a clean **Service Layer Architecture**.

This project demonstrates industry-grade backend skills including domain modeling, DTO mapping, validation, dependency injection, layered design, RESTful API structure, and database persistence.

---

## 🚀 Features

### Patients
- Create patient
- Retrieve single patient
- Retrieve list of patients

### Invoices
- Create invoice
- Retrieve invoice by ID
- Retrieve all unpaid invoices (sorted by due date)

### Payments
- Post a payment
- Automatically update invoice as paid
- Retrieve all payments
- Retrieve payments for a specific invoice

---

## 🧱 Architecture Overview

This backend follows a clean layered architecture:
Controllers → Services → EF Core (DbContext) → SQL Server
DTOs ↔ AutoMapper ↔ Entities
Validators → FluentValidation


### ✔ Controllers
- Expose REST endpoints only — no business logic.

### ✔ Services
- Encapsulate business logic:
  - Applying payments
  - Summing unpaid invoices
  - Creating entities
  - Enforcing domain rules

### ✔ Data Layer
- `BillingContext` uses EF Core
- SQL Server as persistent storage
- Navigation properties manage relationships

### ✔ DTO + AutoMapper
- EF entities are never exposed directly
- All API input/output handled via DTOs
- AutoMapper handles clean mapping

### ✔ FluentValidation
- Each Create DTO has validation:
  - Required fields
  - Length and numeric checks
  - Custom rules

---

## 📂 Project Structure
BillingAPI/
│
├── Controllers/
│     ├── PatientsController.cs
│     ├── InvoicesController.cs
│     └── PaymentsController.cs
│
├── DTOs/
│     ├── PatientDto.cs
│     ├── CreatePatientDto.cs
│     ├── InvoiceDto.cs
│     ├── CreateInvoiceDto.cs
│     ├── PaymentDto.cs
│     └── CreatePaymentDto.cs
│
├── Models/
│     ├── Patient.cs
│     ├── Invoice.cs
│     └── Payment.cs
│
├── Services/
│     ├── IPatientService.cs / PatientService.cs
│     ├── IInvoiceService.cs / InvoiceService.cs
│     └── IPaymentService.cs / PaymentService.cs
│
├── Validators/
│     ├── CreatePatientDtoValidator.cs
│     ├── CreateInvoiceDtoValidator.cs
│     └── CreatePaymentDtoValidator.cs
│
├── Mappings/
│     └── BillingProfile.cs
│
├── Data/
│     └── BillingContext.cs
│
└── Program.cs

---

## 🗄 Database

Created using **EF Core Migrations**.

### Tables
- Patients
- Invoices
- Payments

### Relationships
- A Patient has many Invoices  
- An Invoice has many Payments  
- A Payment belongs to one Invoice

---

## 🔌 REST API Endpoints

### Patients
- `GET /api/patients` — Get all patients  
- `GET /api/patients/{id}` — Get one patient  
- `POST /api/patients` — Create a patient  

### Invoices
- `GET /api/invoices/unpaid` — Get unpaid invoices  
- `GET /api/invoices/{id}` — Get invoice by ID  
- `POST /api/invoices` — Create an invoice  

### Payments
- `POST /api/payments` — Apply a payment  
- `GET /api/payments` — Get all payments  
- `GET /api/payments/invoice/{id}` — Get payments by invoice  

---

## 🗜 Technologies Used

- C# / .NET 8  
- ASP.NET Core Web API  
- Entity Framework Core 9  
- SQL Server  
- AutoMapper  
- FluentValidation  
- Swagger / OpenAPI  
- Built-in Dependency Injection

---

## 🧪 Testing with Swagger

Swagger UI loads automatically at:
https://localhost:<port>/swagger


From here, you can test:
- Create Patient
- Create Invoice
- Apply Payment
- View unpaid invoices
- View payments for invoice

---

## 🧠 Key Concepts Demonstrated

- ✔ **Decoupled Architecture** — Controllers depend on service interfaces (SOLID)
- ✔ **DTO Mapping** — Hides database internals from API consumers
- ✔ **EF Core Queries** — Uses `.Include()`, `.Where()`, `.OrderBy()`, `.AddAsync()`, `.SaveChangesAsync()`
- ✔ **Validation Pipeline** — FluentValidation protects endpoints from invalid input
- ✔ **Professional REST Design** — Clean, semantic URLs like:
  - `/api/invoices/unpaid`
  - `/api/payments/invoice/3`

---

## 📦 How to Run Locally

1. **Update Connection String**  
   In `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_MACHINE;Database=BillingDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
dotnet ef database update
dotnet run
https://localhost:<port>/swagger

Absolutely, Jerome — your content is solid, but I’ll help you polish it into a clean, professional, and well-formatted  that looks great on GitHub. Here's the improved version:


Controllers → Services → EF Core (DbContext) → SQL Server
DTOs ↔ AutoMapper ↔ Entities
Validators → FluentValidation

BillingAPI/ ├── Controllers/ │   ├── PatientsController.cs │   ├── InvoicesController.cs │   └── PaymentsController.cs │ ├── DTOs/ │   ├── PatientDto.cs │   ├── CreatePatientDto.cs │   ├── InvoiceDto.cs │   ├── CreateInvoiceDto.cs │   ├── PaymentDto.cs │   └── CreatePaymentDto.cs │ ├── Models/ │   ├── Patient.cs │   ├── Invoice.cs │   └── Payment.cs │ ├── Services/ │   ├── IPatientService.cs / PatientService.cs │   ├── IInvoiceService.cs / InvoiceService.cs │   └── IPaymentService.cs / PaymentService.cs │ ├── Validators/ │   ├── CreatePatientDtoValidator.cs │   ├── CreateInvoiceDtoValidator.cs │   └── CreatePaymentDtoValidator.cs │ ├── Mappings/ │   └── BillingProfile.cs │ ├── Data/ │   └── BillingContext.cs │ └── Program.cs

https://localhost:<port>/swagger

2. 	Apply EF Core Migrations

3. 	Run the App

4. 	Open Swagger:


📝 Future Enhancements
• 	Authentication / Authorization (JWT)
• 	Pagination on list endpoints
• 	Claim submission workflow
• 	Email reminders for unpaid invoices
• 	Full front-end integration (React/TypeScript or Angular)
• 	Soft deletes & audit logs (HIPAA considerations)

👤 Author
Jerome Cagado
Veteran | Software Engineer | MSSA Graduate
GitHub: @jeromecagado

