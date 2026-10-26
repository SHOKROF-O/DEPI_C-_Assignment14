# Session 14 - Assignment

C# - ASP.Net Course

## Topics
- EF Core Code First
- Navigation Properties
- One-to-Many and Many-to-Many (with a joining table)
- Fluent API (composite key)

## Projects
1. E-commerce System
2. Library System
3. Health Care System

Each project has an Entities folder, a Data folder (DbContext), Program.cs and an ERD.png.

## Run
```
dotnet run   (Program.cs runs Database.Migrate and creates the database)
```
The Init migration is already in each project (Migrations folder). Needs SQL Server on `.` and the packages Microsoft.EntityFrameworkCore.SqlServer and Microsoft.EntityFrameworkCore.Tools.
