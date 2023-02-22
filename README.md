# WineCellar
WineCellar is a wine cellar management application. It's primary use is to track all wines within a cellar.

## Tools
### Entity Framework Core
Add migration  
`dotnet ef migrations add {{MIGRATION_NAME}} --project WineCellar.Infrastructure --startup-project WineCellar.Blazor`

Update database  
`dotnet ef database update --project WineCellar.Infrastructure --startup-project WineCellar.Blazor`

### Azure SQL Edge Docker container
This will run a Azure SQL Edge container on localhost port 1401.  
`docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD={{PASSWORD}}" -p 1401:1433 --name sql1 --hostname sql1 -d mcr.microsoft.com/azure-sql-edge:latest`

## Project Structure
The project's structure is based on the principles of clean architecture with the typical domain, application, infrastructure and frontend (Blazor in this case) layers.
The project is loosely based on https://github.com/jasontaylordev/CleanArchitecture

### WineCellar.Application
This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### WineCellar.Blazor
This layer is a single page application based on Blazor Server and .NET7. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only `Program.cs` should reference Infrastructure.

### WineCellar.Domain
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### WineCellar.Infrastructure
This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.
