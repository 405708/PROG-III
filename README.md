# PROG-III

NuGets:
- Microsoft.entityFrameworkCore
- Microsoft.entityFrameworkCore.SqlServer
- Microsoft.entityFrameworkCore.Design
- Microsoft.entityFrameworkCore.Tools
- Automapper
- FluentValidations.AspNetCore
- Microsoft.AspNetCore.Authentication.JwtBearer

Powershell:
- dotnet tool install --global dotnet-ef

Migrations:
- dotnet ef migrations add InitialCreate
- dotnet ef database update

Scaffolding:
- dotnet ef dbcontext scaffold "Name=nombreDB" Microsoft.EntityFrameworkCore.SqlServer -o Models