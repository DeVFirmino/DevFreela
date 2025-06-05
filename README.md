# DevFreela

Welcome to **DevFreela**, a robust and intuitive API designed to manage projects between clients and freelancers! 
This project was built with ASP.NET Core and aims to facilitate the connection between those who need services and those who offer quality solutions.

---

## About the Project

DevFreela is an API that allows:

- **Clients** to create and manage projects.
- **Freelancers** to apply for projects and track their progress.
- **Efficient management** of tasks, deadlines, and deliveries.

The purpose of this project is to apply and review key API concepts such as controllers, actions, endpoints, dependency injection, exception handling, and file uploads.

---

## Technologies Used

- **Language**: C#
- **Framework**: ASP.NET Core (.NET 9)
- **Main Features**:
    - Controllers and Actions to manage users, projects, and skills
    - RESTful endpoints for CRUD operations
    - Dependency Injection for greater modularity and testability
    - Exception Handling for a better error experience
    - File upload functionality for images and documents
    - Swagger for API documentation

---

## How to Run the Project

### Prerequisites

- .NET SDK  
- Code editor (Visual Studio, Rider, VS Code etc.)

### Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/DeVFirmino/DevFreela
   ```
2. **Navigate to the project folder:**
   ```bash
   cd DevFreela
   ```
3. **Restore dependencies:**
   ```bash
   dotnet restore
   ```
4. **Run the project:**
   ```bash
   dotnet run
   ```

5. Access the API via [http://localhost:5000/swagger](http://localhost:5000/swagger) 
(or the port shown in your console)

---

## Project Structure

- **Controllers**: Manage API endpoints (Projects, Users, Skills)
- **Models**: Represent system entities (Projects, Users, Skills, Comments)
- **Services**: Hold business logic and app rules
- **Middlewares**: Handle exceptions and global features
- **Configuration**: Dependency injection, app settings, file upload configs

---

## Main Features

- **Project Registration**: Clients can create projects (title, description, deadline, budget)
- **Freelancer Application**: Freelancers can apply for available projects
- **File Upload**: Upload profile pictures and documents
- **Exception Handling**: Custom error processing for a better user experience
- **RESTful Endpoints**: Full CRUD support for projects, users, and skills

---
 