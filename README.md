# Product Listing Application

This is a **Product Listing Application** built using **ASP.NET MVC** with **SQL Server** and **Entity Framework**. It demonstrates CRUD (Create, Read, Update, Delete) operations, including functionality for managing product images.

## Features

- Add, view, update, and delete products.
- Upload and display product images.
- Entity Framework integration for database operations.
- SQL Server database for persistent storage.
- User-friendly UI for managing products.

## Technologies Used

- **Backend:** ASP.NET MVC
- **Database:** SQL Server
- **ORM:** Entity Framework
- **Frontend:** HTML, CSS, Bootstrap
- **IDE:** Visual Studio

## Project Structure

/Controllers   - Contains the MVC controllers
/Models        - Entity classes and database context
/Views         - Razor views for user interface
/Content       - Static files like CSS and images
/Scripts       - JavaScript files
/App_Data      - Database files (if applicable)

## Prerequisites

1. **Visual Studio** (2019 or later recommended)
2. **SQL Server** (2017 or later)
3. **.NET Framework** (4.7.2 or later)

## Installation Instructions

1. Clone this repository:
   ```bash
   git clone https://github.com/harinik28/Product-Listing-Application.git
2. Open the solution file (`CRUDOperationsMVC.sln`) in Visual Studio.
3. Set up the database:
   - Update the connection string in `Web.config`:
     ```xml
     <connectionStrings>
         <add name="DefaultConnection" connectionString="Your SQL Server connection string" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```
   - Run the Entity Framework migrations to create the database:
     ```bash
     Update-Database
     ```
4. Build and run the application.

## Usage

1. Navigate to the product listing page.
2. Use the following features:
   - **Add Product:** Add a new product with details and an image.
   - **Edit Product:** Update product details and images.
   - **Delete Product:** Remove a product from the list.
   - **View Products:** See a list of all products with their details and images.


