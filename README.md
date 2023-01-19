# WineCellar
WineCellar is a wine cellar management application. It's primary use is to track all wines within a cellar.

## Tools
### Entity Framework Core
Add migration  
`dotnet ef migrations add {{MIGRATIONNAME}} --project WineCellar.Infrastructure --startup-project WineCellar.Blazor`

Update database  
`dotnet ef database update --project WineCellar.Infrastructure --startup-project WineCellar.Blazor`  

## Project Structure
The project's structure is based on the principles of clean architecture with the typical domain, application, infrastructure and frontend (Blazor in this case) layers.

### WineCellar.Application
This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### WineCellar.Blazor
This layer is a single page application based on Blazor Server and ASP.NET Core 7. This layer depends on both the Application and Infrastructure layers, however, the dependency on Infrastructure is only to support dependency injection. Therefore only `Startup.cs` should reference Infrastructure.

### WineCellar.Domain
This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### WineCellar.Infrastructure
This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.
