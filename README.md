# AllDo: Minimal API Project

## Overview

AllDo is a Todo app designed to showcase my skills and expertise as a developer. This project represents the back end of the application, implemented using .NET Core 7 and written in C# 10. The application is structured into three main projects: Domain, API, and Infrastructure.

## Projects

### 1. Domain Project

The **Domain** project encapsulates the core business logic and entities for AllDo. It defines the fundamental structures and functionalities, including Todo items, Bugs, and Features. This project ensures a clean separation of concerns and allows for easy extension and modification of business rules.

### 2. API Project

The **API** project is the heart of AllDo, providing RESTful API endpoints to interact with the application. It leverages the minimal API capabilities in .NET Core 7 to keep the codebase concise and focused. This project exposes endpoints for managing Todos, Bugs, and Features, supporting basic CRUD operations.

### 3. Infrastructure Project

The **Infrastructure** project contains components related to data access, third-party integrations, and other infrastructure concerns. It serves as the bridge between the domain and the data storage, ensuring a scalable and maintainable architecture.

## Getting Started

To run the AllDo Minimal API project locally, follow these steps:

1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/Motunrayo-O/AllDo.git
    ```

2. Navigate to the API project directory:

    ```bash
    cd AllDo/AllDo.Api
    ```

3. Build and run the project:

    ```bash
    dotnet run
    ```

4. Open your preferred API testing tool (e.g., [Postman](https://www.postman.com/)) and start interacting with the AllDo API at `https://localhost:4000`.

## Dependencies

- .NET Core 7
- C# 10

## Future Enhancements

This portfolio project is continually evolving. Planned future enhancements include:

- Improved error handling and logging.
- Integration with a front-end application for a complete user experience.
- Enhanced security features such as authentication and authorization.

Feel free to explore, provide feedback, and connect with me for any inquiries or collaboration opportunities.

Happy coding!
Motunrayo
