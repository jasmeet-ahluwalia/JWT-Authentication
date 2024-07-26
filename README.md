# JWT Authentication with Entity Framework Core in C#

This project demonstrates a simple implementation of JWT (JSON Web Tokens) authentication for login and registration functionalities using Entity Framework Core in C#.

# Features

- Login: Users can authenticate by providing their email and password. Upon successful authentication, a JWT token is generated and returned.
- Registration: New users can create accounts by supplying their details such as name, email, and password.
- JWT Token: JWT tokens are utilized for authentication, ensuring secure communication between client and server.
- Entity Framework Core: The application interacts with the database using Entity Framework Core, simplifying data management.

  ## Setup Instructions

  ### Clone the Repository

  1 Clone the Repository: Clone this repository to your local machine.

```bash
git clone https://github.com/jasmeet-ahluwalia/JWT-Authentication
```

2 Database Configuration: Ensure you have SQL Server installed and running. Update the connection string in the appsettings.json file with your database credentials.

```bash
"ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_database;User=your_username;Password=your_password;"
}
```

3 Run Migrations: Execute Entity Framework Core migrations to create the required database schema.

```bash
dotnet ef database update
```

4 Start the Application: Launch the application using the following command:

```bash
dotnet run
```

5 API Endpoints:

- POST /api/auth/login: Endpoint for user authentication. Requires email and password.
- POST /api/auth/register: Endpoint for user registration. Requires name, email, and password

### Dependencies

- **Microsoft.AspNetCore.Authentication.JwtBearer**: Handles JWT authentication.
- **Microsoft.EntityFrameworkCore**: For database operations with Entity Framework Core.
- **Microsoft.EntityFrameworkCore.Tools**: Tools for Entity Framework Core, including migrations.
- **BCrypt.Net**: Utilized for secure password hashing.
- **Microsoft.EntityFrameworkCore.SqlServer**: SQL Server database provider for Entity Framework Core.

  ### Technologies Used

  - C#
  - ASP.NET Core
  - Entity Framework Core
  - JWT JSON Web Tokens
  - SQL Server
