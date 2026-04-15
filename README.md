# Appointment Booking API

A backend API built with .NET 8 for managing appointments with authentication and a layered architecture.

---

## Features

* JWT Authentication
* Create, Update, Delete Appointments
* Get All and Get By ID
* Layered Architecture (Controller → Service → Repository)
* SQL Server (Docker)
* Entity Framework Core (Code First)
* Scalar API UI

---

## Tech Stack

* .NET 8 Web API
* Entity Framework Core
* SQL Server (Docker)
* JWT Authentication
* Scalar UI

---

## Project Structure

```
Appointment_Booking_Api/
│
├── Controllers/
├── DTOs/
├── Data/
├── Models/
├── Repositories/
├── Services/
├── Middlewares/
├── Migrations/
│
├── Program.cs
├── appsettings.json
├── .gitignore
```

---

## Run Locally

### Clone repository

```
git clone https://github.com/anshika171/Appointment-Booking-API.git
cd Appointment-Booking-API
```

---

### Run SQL Server (Docker)

```
docker run -e "ACCEPT_EULA=Y" \
-e "SA_PASSWORD=StrongPass@123" \
-p 1433:1433 \
--name sqlserver \
-d mcr.microsoft.com/mssql/server:2022-latest
```

---

### Apply migrations

```
dotnet ef database update
```

---

### Run API

```
dotnet run
```

---

## Authentication

### Login

```
POST /api/Auth/login
```

Example request:

```
{
  "username": "admin",
  "password": "1234"
}
```

---

### Use token

```
Authorization: Bearer YOUR_TOKEN
```

---

## API Endpoints

| Method | Endpoint              | Description |
| ------ | --------------------- | ----------- |
| POST   | /api/Auth/login       | Login       |
| GET    | /api/Appointment      | Get all     |
| GET    | /api/Appointment/{id} | Get by ID   |
| POST   | /api/Appointment      | Create      |
| PUT    | /api/Appointment/{id} | Update      |
| DELETE | /api/Appointment/{id} | Delete      |

---

## API UI

http://localhost:5026/scalar

---

## Notes

Use ISO date format:

```
YYYY-MM-DD
```

Example:

```
2026-01-01
```

---


