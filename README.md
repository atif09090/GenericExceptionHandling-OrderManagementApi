# 🧾 GenericExceptionHandling-OrderManagementApi

A lightweight ASP.NET Core 8 Web API demonstrating **robust exception handling** using:

- ✅ Try-catch with structured error propagation
- ✅ Centralized global exception middleware
- ✅ Logging with `ILogger`
- ✅ `ProblemDetails` for consistent error responses
- ✅ Real-world service and repository pattern

---

## 🧰 Technologies Used

- ASP.NET Core 8 (Minimal API + MVC Controller)
- Middleware
- `ILogger<T>` logging
- `ProblemDetails` (RFC 7807)
- C# 12

---
## 🏗️ Project Structure

```plaintext
GenericExceptionHandling-OrderManagementApi/
├── Controllers/
│ └── OrdersController.cs
├── Middlewares/
│ └── ExceptionHandlingMiddleware.cs
├── Repositories/
│ └── OrderRepository.cs
├── Services/
│ └── OrderService.cs
├── Models/
│ └── Order.cs
├── Program.cs
└── README.md


---

## 🔄 API Endpoints

| Method | Endpoint        | Description              |
|--------|------------------|--------------------------|
| GET    | `/api/orders/{id}` | Retrieves an order by ID |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio / VS Code

### Run Locally

```bash
git clone https://github.com/yourusername/OrderManagementApi.git
cd OrderManagementApi
dotnet run


