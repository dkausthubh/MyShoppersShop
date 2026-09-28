# MyOnlineShop

An online shopping web application built with ASP.NET MVC and C#, with a customer storefront and an admin area for managing the catalogue.

## Features
- Product catalogue and browsing [add: search / filter / categories]
- [Shopping cart and checkout]
- [User registration and login]
- Admin area for managing [products / orders / users]

## Tech Stack
- C#, ASP.NET MVC (.NET Framework [version])
- [Entity Framework / ADO.NET] with SQL Server
- Razor Views, Bootstrap, JavaScript

## Architecture
Layered structure:
- **Controllers:** handle requests and return views
- **Repository:** data-access abstraction used by controllers
- **DAL:** database context and data access
- **Models:** domain and view models
- **Views:** Razor UI, with separate admin styling

## Getting Started
1. Clone the repository
2. Open `MyOnlineShop.sln` in Visual Studio
3. Update the connection string in `Web.config`
4. [Run migrations / execute the SQL script]
5. Press F5


## Future Improvements
- Migrate to ASP.NET Core
- Add unit tests
- Add payment gateway integration
