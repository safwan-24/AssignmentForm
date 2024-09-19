### Student Management System

This project is a basic Windows Forms application for managing student records. It allows users to add, edit, delete, and view student information from an SQL Server database.

## Features
- **Add Students**: Insert a new student's name, age, and phone number into the database.
- **Edit Students**: Update existing student records.
- **Delete Students**: Remove student records from the database.
- **Display Students**: Display the list of all students in a DataGridView.

## Requirements
- Visual Studio (or any C# IDE)
- SQL Server
- .NET Framework (compatible with Windows Forms)
- SQL Server database named `Student` with a table `StudentTbl`



```md

CREATE TABLE [dbo].[StudentTbl] (
    [StudentId]    INT          IDENTITY (500, 1) NOT NULL,
    [StudentName]  VARCHAR (50) NOT NULL,
    [StudentAge]   VARCHAR (50) NOT NULL,
    [StudentPhone] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);
```

## How to Run
1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Update the connection string to match your SQL Server configuration. Modify the line in `Form1.cs` where the `SqlConnection` is declared:

```csharp
SqlConnection Con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True");
```

4. Ensure that your SQL Server instance is running and the `Student` database with the `StudentTbl` table exists.
5. Build and run the project in Visual Studio.

## Database Operations
- **Add Students**: Inserts a new student record using the following query:
  
  ```sql
  INSERT INTO StudentTbl (StudentName, StudentAge, StudentPhone) 
  VALUES (@StudentName, @StudentAge, @StudentPhone)
  ```
  
- **Edit Students**: Updates an existing student record:
  
  ```sql
  UPDATE StudentTbl 
  SET StudentName=@StudentName, StudentAge=@StudentAge, StudentPhone=@StudentPhone 
  WHERE StudentId=@StudentKey
  ```
  
- **Delete Students**: Deletes a student record based on the `StudentId`:
  
  ```sql
  DELETE FROM StudentTbl 
  WHERE StudentId=@StudentKey
  ```

## Key Functions
- **populate()**: Populates the DataGridView with student data from the database.
- **AddBtn_Click()**: Inserts a new student into the database and refreshes the DataGridView.
- **EditBtn_Click()**: Edits the selected student's details in the database.
- **ClearBtn_Click()**: Deletes the selected student from the database.
- **StudentDGV_CellContentClick()**: Fills the text boxes with data from the selected row in the DataGridView.
- **clear()**: Resets all text fields and clears the selected student ID.

## Notes
- Be sure to handle edge cases like empty input fields or invalid data (e.g., age as non-integer values).
- The `SqlConnection` is properly closed after every database operation, ensuring that there are no hanging connections.
```

This structure follows common conventions for a `README.md` file, detailing features, requirements, and how to run the project. Let me know if you need further adjustments!
