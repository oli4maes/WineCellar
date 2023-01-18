# WineCellar
WineCellar is a wine cellar management application. It's primary use is to track all wines within a cellar.

## Tools
### Entity Framework Core
Add migration
`dotnet ef migrations add {{MIGRATIONNAME}} --project WineCellar.Infrastructure --startup-project WineCellar.Blazor`
Update database
`dotnet ef database update --project WineCellar.Infrastructure --startup-project WineCellar.Blazor`
