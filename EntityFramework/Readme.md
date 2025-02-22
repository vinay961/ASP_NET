# Entity Framework
- It is an ORM(object-Relational mapping) framework for .NET application
- It is implementation of Entity Data Model(EDM), EDM is modal that describe the entities and relation between them.
- It is the enhancement of ADO.NET, using EF developers issue queries using LINQ(Language integrated query).


## Approaches to manage data related to the application
- Code first approach: We write C# classes (called models) first, and Entity Framework creates the database based on those classes.
- Database first approach: The database already exists, and EF generates C# classes (models) from it.
- Model first approach: We create a visual diagram (EDMX file) first, and EF generates both the database and C# classes.


## Code first approach steps

- Create Model Class → Defines table structure.
-  Create DbContext Class → Manages database connection.
- Add Connection String → In appsettings.json (for database connection).
- Use DbContext in Controller → Fetch & send data to view.
- Display Data in View


### Here’s how data moves in ASP.NET Core MVC:

🛠 From Database to View (Reading Data)
- User visits /User/Index.
- UserController.Index() fetches data from Users table using _context.Users.ToList();.
- The data is sent to Index.cshtml View.
- The View displays the data as an HTML table.

📝 From View to Database (Saving Data)
- User fills a form and clicks Submit.
- Form data is sent to UserController via HTTP POST.
- UserController saves the data in the database using _context.Users.Add(user); _context.SaveChanges();.
- Database stores the new record.
- User is redirected to the Index page, where the new data is displayed.