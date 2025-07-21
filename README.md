Student Management System
This project is a ASP.NET Core MVC-based school management system developed for Kocaeli University. The system provides functionalities according to the access levels of different user roles such as student, faculty member, department secretary, and department head.

Features
Roles and Permissions
1. Department Head
Access to all modules.

Can manage user authorizations.

Can manage courses, classrooms, course schedules, and exams.

Can assign courses to faculty members.

Can determine exam seating arrangements.

2. Department Secretary
Can create user registrations.

Can manage courses and classrooms.

Can create and list course schedules.

Can assign courses to faculty members.

Can view faculty members' schedules.

3. Faculty Member
Can view their own course and exam schedules.

Can enter grades.

4. Student
Can view their own course and exam schedules.

Main Modules
User Management: Adding students and faculty members.

Course Management: Adding and listing courses.

Classroom Management: Listing classrooms.

Course Scheduling: Creating and listing course schedules by term and class.

Exam Management: Adding, listing exams, and viewing personal exam schedules.

Assigning Courses to Faculty Members: Matching courses with faculty members.

Technologies
ASP.NET Core MVC

Entity Framework Core (EF Core)

SQL Server

HTML5, CSS3, Bootstrap

Session Management (Role-based access control)

How to Use the Project
Clone the project:

bash
Kopyala
Düzenle
git clone https://github.com/furkanaltuntabak/studentmanagementsystem.git
Create the database:

The necessary DbSets are defined inside AppDbContext.cs.

Run the following command to create the database:

bash
copy
edit
dotnet ef database update
Run the application:

bash
copy
edit
dotnet run
Login details:

Login page: /Account/Login

The UI will automatically adjust based on the user role.

Project Structure
Controllers/: MVC controller files

Models/: Entity classes

Views/: Razor view files

wwwroot/: Static files (CSS, JS)

Data/AppDbContext.cs: EF Core database context

Contribution
This project was prepared as a university assignment and is not open for contributions. However, it can be used for reference purposes.
