# Employee Directory System

A comprehensive software solution designed to manage a corporate directory, featuring a decoupled N-tier architecture with a secure **ASP.NET Core Web API** and a **WPF desktop client**.

## 🚀 Key Features

* **Employee Management:** Full CRUD operations for employee profiles, departments, and office sites.
* **N-Tier Architecture:** Complete separation of concerns between data, business logic, and presentation layers.
* **Interactive API Documentation:** Fully documented REST endpoints using Swagger UI for easy testing and integration.
* **Security First:** Integrated password hashing system using BCrypt for secure administrator authentication.
* **Data Consistency:** Implementation of Entity Framework Core with SQLite for reliable data persistence.
* **Smart Search:** Real-time filtering system by name, department, or office location.

## 🛠 Tech Stack

* **Backend:** .NET 8, ASP.NET Core Web API, Entity Framework Core.
* **API Documentation:** Swagger (OpenAPI 3.0).
* **Frontend:** WPF (Windows Presentation Foundation) with XAML.
* **Database:** SQLite.
* **Security:** BCrypt.Net for cryptographic hashing.
* **Testing/Mocking:** Bogus library for automated database seeding and realistic data generation.

## 📁 Project Structure

The solution is divided into four main modules:

1.  **ANNUAIRE.API:** The RESTful service handling data logic and requests.
2.  **ANNUAIRE.WPF:** The client-side application for end-users and administrators.
3.  **ClassLibrary:** A shared library containing data models and entities used by both API and Client.
4.  **HashPasswordGenerator:** A specialized utility tool for administrative security management.

## ⚙️ Installation & Setup

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/laurafrnt/Employee-Directory-System.git](https://github.com/laurafrnt/Employee-Directory-System.git)
    ```
2.  **Database Initialization**
    This project uses SQLite. You must apply migrations to create the local database schema. Navigate to the API directory
    and run:
    ```bash
    cd ANNUAIRE/API
    dotnet ef database update
    ```
    Note: This creates the annuaire.db file within the API folder.
    
3. **Populating the Database (Seeding)**
    To test the application with a realistic dataset, run the UtilitaireData project. It utilizes the Bogus library to inject 1000 randomized employees into your local database:
    ```bash
    cd ../UtilitaireData
    dotnet run
    ```

4.  **Run the API:**
    ```bash
    dotnet run
    ```

## 🔍 Exploring the API (Swagger)

Once the API is running, you can access the interactive documentation to test the endpoints directly from your browser:
* **URL:** `https://localhost:[PORT]/swagger` (Check your terminal for the specific port).
* Use the **"Try it out"** button to execute GET, POST, or DELETE requests and see real-time JSON responses.

## 🛡 Security & Best Practices

* **API Security:** The admin section is protected by an authentication layer ensuring that only authorized users can modify data.
* **Code Quality:** Use of Design Patterns (Repository/Controller) to ensure maintainability and scalability.
* **Data Privacy:** Passwords are never stored in plain text, utilizing industry-standard hashing algorithms.

---
*Developed as part of CESI's two-year computer development study programme.*