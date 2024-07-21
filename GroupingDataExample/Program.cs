// Grouping -> GroupBy(); ToLookup();
using GroupingDataExample;
var students = DataSource.GetStudents();

// GroupBy => deferred execution التنفیذ المؤجل
// ToLookup => immediate execution التنفیذ الفوری

// Method Syntax (GroupBy)
var groupedStudent = students.GroupBy(s => s.Country);

// Method Syntax (ToLookup)
var groupedStudentToLookup = students.ToLookup(s => s.Country);

// Query Syntax (GroupBy)
var groupedStudentQuery = from student in students
                          group student by student.Country;


foreach(var element in groupedStudent)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Students From {element.Key}");

    Console.ForegroundColor = ConsoleColor.Green;
    foreach (var student in element) // Each group has an inner collection
    {
        Console.WriteLine($"Student Name: {student.Name}, Student Age: {student.Age}");
    }
    Console.WriteLine();
}

Console.ReadKey();
