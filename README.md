# Task Manager API

## Overview

The Task Manager API is a .NET 8 Web API designed for managing tasks with a Clean Architecture approach. This project demonstrates the use of Clean Architecture principles to create a maintainable, scalable, and testable application. 

### Clean Architecture

Clean Architecture separates the application into distinct layers to enforce a separation of concerns:

- **Core Layer**: Contains business logic and domain entities.
- **Application Layer**: Contains use cases and application logic.
- **Infrastructure Layer**: Contains data access and external service implementations.
- **Presentation Layer**: Contains API controllers and handles HTTP requests.

## Features

- Create, read, update, and delete tasks.
- List all tasks or get tasks by ID.
- Uses Clean Architecture for maintainability and scalability.

## Architecture

- **Core Layer**:
  - `Entities/TaskItem.cs`: Defines the `TaskItem` entity.
  - `Interfaces/ITaskRepository.cs`: Defines the repository interface for task operations.

- **Application Layer**:
  - `Services/TaskService.cs`: Contains business logic and use cases for tasks.

- **Infrastructure Layer**:
  - `Data/TasksDbContext.cs`: Entity Framework Core database context.
  - `Repositories/TaskRepository.cs`: Implementation of the task repository interface.

- **Presentation Layer**:
  - `Controllers/TasksController.cs`: API controllers handling HTTP requests for tasks.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [A SQL Server or In-Memory Database](https://docs.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli)

### Running Locally

1. **Clone the Repository**:
   ```sh
   git clone https://github.com/gondaimgano/TaskManagerCleanArchitectureApiDotNet.git
   cd TaskManager
