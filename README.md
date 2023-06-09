# Hexagonal Architecture. (.NET C# API)

This repository demonstrates the implementation of Hexagonal Architecture in a .NET Core API project. The architecture promotes loose coupling, modularity, and testability, making it easier to develop and maintain scalable applications.

## Project Structure

The codebase is organized into the following projects:

- **Blog.API**: Contains the API controllers and serves as the presentation layer.
- **Blog.Application**: Encapsulates the application layer and orchestrates the business logic and use cases.
- **Blog.Domain**: Houses the domain entities and interfaces defining the core business logic.
- **Blog.Infrastructure**: Implements the infrastructure layer, including data access and external service integrations.

## Getting Started

To get started with the codebase, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/paulap887/Blog.API.HexagonalArch.git

2. Open the solution in your preferred IDE.

3. Build the solution to restore the NuGet packages.

4. Modify the connection string in Blog.Infrastructure/Data/ApplicationDbContext.cs to point to your desired database.

5. Run the API project (Blog.API) to start the application.

6. Use a tool like Postman to interact with the API endpoints.

## Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.
