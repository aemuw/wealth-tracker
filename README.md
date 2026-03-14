# WealthTracker

**WealthTracker** is a personal finance tracking application built with **C# and .NET 8**.

The project includes a **Windows Forms desktop application** and an **ASP.NET Core Web API**, demonstrating concepts such as:

- MVP (Model-View-Presenter) pattern
- Separation of concerns
- Service-based architecture
- Entity Framework Core
- REST API design

The goal of this project is to explore how a desktop client and backend API can work together to manage personal finance data.

---

# Screenshot

![WealthTracker Screenshot](screenshot.png)

---

# Features

## Desktop Application

- Add income and expense transactions by category
- Delete transactions with confirmation
- Filter transactions by keyword and date range
- Visual wallet status indicator based on balance
- Expense distribution **pie chart**
- Balance over time **line chart**
- Export data to **CSV** and **XML**

## Backend API

- ASP.NET Core Web API
- JWT authentication
- Entity Framework Core with SQLite
- REST endpoints for managing transactions
- Service layer for business logic

---

# Tech Stack

## Language
- C# (.NET 8)

## Desktop
- Windows Forms
- Microsoft Chart Controls (MSChart)

## Backend
- ASP.NET Core Web API
- Entity Framework Core
- SQLite

## Architecture
- MVP (Model-View-Presenter)
- Service layer
- Separation of concerns

## Testing
- xUnit
- Moq

## Serialization / Export
- System.Text.Json
- XML
- CSV

---

# Project Structure

```
wealth-tracker
│
├── WealthTracker
│   Windows Forms desktop application
│
├── WealthTracker.Api
│   ASP.NET Core Web API
│
├── WealthTracker.Tests
│   Unit tests
```

---

# Getting Started

## Prerequisites

- Windows OS
- Visual Studio 2022+
- .NET 8 SDK

---

## Installation

```bash
git clone https://github.com/aemuw/wealth-tracker.git
cd wealth-tracker
```

Open the solution:

```
wealth-tracker.sln
```

Run with **F5**.

---

# API Overview

Example endpoints:

```
POST /auth/login
GET /transactions
POST /transactions
DELETE /transactions/{id}
```

The API uses **JWT authentication** and **Entity Framework Core**.

---

# Architecture

## Desktop (MVP)

```
View (WinForms)
   ↓
Presenter
   ↓
Services
   ↓
Persistence
```

## Backend

```
Controller
   ↓
Service
   ↓
Persistence / Repository
   ↓
Database
```

This structure keeps UI, business logic, and persistence separated.

---

# Roadmap

Planned improvements:

- [ ] Introduce DTOs for API models
- [ ] Improve dependency injection usage
- [ ] Add repository pattern
- [ ] Add FluentValidation
- [ ] Improve async EF Core usage
- [ ] Implement Undo/Redo via Command pattern
- [ ] Improve API integration tests
- [ ] Improve documentation

---

# What I Learned

Through this project I practiced:

- Implementing the **MVP pattern**
- Building a **desktop application with Windows Forms**
- Designing **REST APIs with ASP.NET Core**
- Using **Entity Framework Core**
- Implementing **JWT authentication**
- Writing **unit tests with xUnit and Moq**
- Using **LINQ for filtering and aggregation**
- Creating charts with **MSChart**

---

# License

MIT
