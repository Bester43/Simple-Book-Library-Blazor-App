# Book Library Blazor App (.NET 8)

## Overview

This project is an Interactive Server Blazor application developed in .NET 8. It serves as a personal learning resource, showcasing the implementation of various features and technologies. The primary focus is on building a functional book management system using Blazor, a web framework by Microsoft.

## Learning Highlights

### 1. .NET 8 Features

Leveraged the latest features of .NET 8, enhancing performance, security, and development efficiency.

### 2. Blazor Components

Explored and implemented Blazor components for creating dynamic and responsive user interfaces.

### 3. Two-way Data Binding


Utilized two-way data binding to seamlessly connect the UI with the underlying data.

### 4. API Integration with HttpClient

Integrated the Google Books API using the improved capabilities of `HttpClient` for real-time book searches and additions.

### 5. Navigation and Routing

Implemented seamless navigation and routing between different pages for a cohesive user experience.

## App Features

### Add Book Page

Users can search and select books from the Google Books API to expand their library.

![addbook](https://github.com/Bester43/Simple-Book-Library-Blazor-App/assets/59999540/901afd71-3e09-45f4-92dc-ec4240d6c913)

### Edit Book Page

Fine-tune book details such as title, author, and publication year using the editing interface.

![edit](https://github.com/Bester43/Simple-Book-Library-Blazor-App/assets/59999540/5fabef2e-9185-4f76-861a-3368f82a5f10)

### Home Page

Overview of the book library, including a progress bar indicating the percentage of books read.

![home](https://github.com/Bester43/Simple-Book-Library-Blazor-App/assets/59999540/eeafee99-9211-49aa-a52c-bf024e36c30f)

### Library Page

Navigate through the complete book collection, with search functionality and essential actions.

![library](https://github.com/Bester43/Simple-Book-Library-Blazor-App/assets/59999540/809a327b-240c-494f-9938-b4850dc3c648)

## How to Run

1. Clone this repository.
2. Open the project in Visual Studio or your preferred code editor.
3. Ensure you have .NET 8 installed.
4. Update the database connection string in the `appsettings.json` file under `ConnectionStrings` with your SQL Server database information:
```json
{
  "ConnectionStrings": {
    "Default": "YourConnectionStringHere"
  },
  // Other configurations...
}
```
5. Add your Google Books API key in the AddBook.razor page:
```
private async Task SearchGoogleBooks()
{
    var apiKey = "YourGoogleBooksAPIKeyHere";
    var apiUrl = $"https://www.googleapis.com/books/v1/volumes?q={Uri.EscapeDataString(searchQuery)}&key={apiKey}";

    // Other code...
}
```
7. Run the application, and it will launch in your default web browser.
