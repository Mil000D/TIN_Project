# Cinema Manager Web Application

## Overview

This project utilizes tools such as SQLite, Blazor framework with a Code-First approach and MudBlazor to provide a user-friendly and efficient platform for managing cinemas, movies, genres, and repertoires.
The Cinema Manager Web Application supports multiple languages to enhance user experience. Currently, the application is available in English and Polish.
## Features

### For Guests

- **View Cinemas and Repertoire:** Users can select from a list of cinemas and explore the movie repertoire for each cinema.
- **Movie Details:** Access detailed information about movies, including, title, description, trailer etc.
- **Account Creation:** Users can create account by using register option or if they have an account to log in.

### For Customers
- **Ticket Booking and Purchase:** Users have the ability to book or buy tickets for their preferred movies seamlessly.
- **Account Management:** Users can manage their accounts, update personal information, and view their order history.

### For Admins

- **Cinema Management:** Admins can perform full CRUD operations on cinemas.
- **Movie Management:** Admins have control over the movie database, enabling them to add new movies, update existing information, or remove outdated entries.
- **Genre Management:** Admins can manage movie genres, ensuring a well-organized and categorized collection.
- **Repertoire Management:** Admins have the capability to schedule movie screenings, adjusting show times as needed.
- **Account Management:** Admins can manage their accounts and update personal information.
  
### For Superuser

- **All Admin Rights:** Superuser possesses all the rights and functionalities of regular admins, ensuring comprehensive control over the application.
- **Users Management:** Superuser is able to add new admins and delete users from the system.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) must be installed.
- To seed database by yourself you need to have Entity Framework Core tools installed. To do it, go to CLI like cmd and use command : `dotnet tool install --global dotnet-ef` to install the tool.
- A supported IDE, such as Visual Studio or Rider, is recommended.

### Setup

1. Clone the repository or just download zip
2. Navigate to the project directory
3. Run the application use the script `startServer.bat` to start application
4. After application is successfully built, follow the link that is shown in a window

### Remarks
Database is seeded and is available in directory `TIN_Project/Server/Database`. If you want to run script that will seed database by yourself just delete it from directory, create it once more giving it the same name and extension `database.db` and after that run script `seedDatabase.bat`.

To log into account you can use either accounts already seeded into database or create your own, just navigate to Login page by clicking button in the top right corner. However, if you want to see all of the functionalities of the application based on roles it is recommended to use one of those three accounts:
1. Customer - Username : `username`, Password : `password`
2. Admin - Username : `admin`, Password : `password`
3. Superuser - Username : `superuser`, Password : `password`
