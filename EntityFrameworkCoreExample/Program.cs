using EntityFrameworkCoreExample;

// needed using to do an instance of student database context
// this is an object that connects to database it's like a gateway
using StudentContext dbContext = new();

// if we want to add things to database
// Add with EF Core
Student s = new()
{
    FullName = "Jade Ferguson",
    EmailAddress = "Jade.Ferguson@cptc.edu",
    DateOfBirth = new DateTime(2000, 1, 1)
};

Student s2 = new()
{
    FullName = "Zack Fair",
    EmailAddress = "Zack.Fair@cptc.edu",
    DateOfBirth = new DateTime(2000, 1, 1)
};

dbContext.Students.Add(s); // Prepares the Student insert statement
dbContext.SaveChanges(); // Executes pending insert. (In Actuality: Execute any pending insert/update/delete)

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // Method syntax

/*allStudents = (from stu in dbContext.Students
               select stu).ToList(); // Query syntax */

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
    Console.WriteLine();
}