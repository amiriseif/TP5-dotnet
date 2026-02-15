# TP5 — My Implementation (ASP.NET Core Identity)

Author: Student Seifeddine Amiri

This repository contains my TP5 implementation. I implemented ASP.NET Core Identity with a custom `ApplicationUser`, added a `City` field, created registration/login flows, and implemented product and per-user cart models.

## What I did (summary)
- Wired Identity to EF Core using `ApplicationUser` and `ApplicationDbContext` in `Program.cs`.
- Extended the registration page to collect `City` and create users with that data.
- Updated `_LoginPartial` and controller injections to use `ApplicationUser` so DI resolves `UserManager<ApplicationUser>` / `SignInManager<ApplicationUser>`.
- Implemented `Produit` and `PanierParUser` models and seeded sample products on startup.
- Added a `UserManagement` page (controller action + view) that lists registered users (Email and City).

## How to run (developer instructions)
1. Ensure you have .NET 8 SDK installed.
2. Update the database connection string in `appsettings.json` if needed (key: `DefaultConnection`).
3. Build:

```powershell
dotnet build
```

4. Apply migrations (creates Identity and application tables):

```powershell
dotnet ef database update
```

5. Run the app:

```powershell
dotnet run
```

Open the URL shown in the console (usually `https://localhost:5001` or similar).

## How to test the implemented features
- Register a new user: `Register` collects Email, Password, Confirm password, and City.
- Login and verify the `_LoginPartial` shows your user.
- Visit `/Account/UserManagement` (requires authentication) to see the list of users and their City values.
- Browse the home page to see seeded products.

## Important files
- `Program.cs` — Identity setup, DB context registration, and product seeding.
- `Data/ApplicationUser.cs` — custom user model with `City`.
- `Areas/Identity/Pages/Account/Register.cshtml` (+ `.cs`) — registration UI and logic.
- `Views/Account/UserManagement.cshtml` — lists users.
- `Migrations/20260215123508_InitialCreate.Designer.cs` — migration snapshot showing Identity tables and `City` column.

## Notes
 I added seeding for sample products in `Program.cs` so the site shows example items on first run.
