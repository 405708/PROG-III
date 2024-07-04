# PROG-III

NuGets:
- Microsoft.entityFrameworkCore
- Microsoft.entityFrameworkCore.SqlServer
- Microsoft.entityFrameworkCore.Design
- Microsoft.entityFrameworkCore.Tools
- FluentValidations.AspNetCore
- JWT

Powershell:
- dotnet tool install --global dotnet-ef

Migrations:
- dotnet ef migrations add InitialCreate
- dotnet ef database update

Scaffolding:
- dotnet ef dbcontext scaffold "Name=pilotoDB" Microsoft.EntityFrameworkCore.SqlServer -o Models