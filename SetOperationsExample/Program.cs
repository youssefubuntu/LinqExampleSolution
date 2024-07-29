// Set Operations 
using SetOperationsExample;

/************************* Distinct & DistinctBy *************************/
// Distinct
//var students = Student.GetStudents();
//var colors = new List<string> { "red", "blue", "yellow", "red", "blue", "black", "white" };

//var uniqueColors = colors.Distinct();
//var uniqueColorsQuery = from color in colors.Distinct() select color;
//foreach(var color in uniqueColors)
//    Console.WriteLine(color);

// DistinctBy
//var uniqueStudents = students.DistinctBy(s => s.Name);
//foreach(var student in uniqueStudents)
//    Console.WriteLine(student.ToString());


/************************* Except & ExceptBy *************************/
// Except
//var colors = new List<string> { "red", "blue", "yellow", "black", "white" };
//var colorsTwo = new List<string> { "yellow", "blue" };

//var exceptResult = colors.Except(colorsTwo);
//foreach (var color in exceptResult)
//    Console.WriteLine(color);

//// ExceptBy
//var students = Student.GetStudents();
//var studentsToExclude = new List<string> { "Mazen", "Basem" };
//var studentsTwo = Student.GetStudentsTwo();
//var studentsToExcludeTwo = studentsTwo.Select(s => s.Name);

//var exceptByResult = students.ExceptBy(studentsToExcludeTwo, s => s.Name);
//foreach (var student in exceptByResult)
//    Console.WriteLine(student.ToString());

/************************* Intersect & IntersectBy *************************/
// Intersect
//var colors = new List<string> { "red", "blue", "yellow", "black", "white" };
//var colorsTwo = new List<string> { "yellow", "blue","purple", "skyblue" };
//var intersectResult = colors.Intersect(colorsTwo);
//foreach (var color in intersectResult)
//    Console.WriteLine(color);

//// IntersectBy
//var students = Student.GetStudents();
//var studentsToInclude = new List<string> { "Mazen", "Basem" };
//var studentsToIncludeTwo = Student.GetStudentsTwo().Select(s => s.Name);

//var intersectByResult = students.IntersectBy(studentsToIncludeTwo, s => s.Name);
//foreach (var student in intersectByResult)
//    Console.WriteLine(student.ToString());

/************************* Union & UnionBy *************************/
//// Union
//var colors = new List<string> { "red", "blue", "yellow", "black", "white" };
//var colorsTwo = new List<string> { "yellow", "blue", "purple" };

//var unionResult = colors.Union(colorsTwo);
//foreach (var color in unionResult)
//    Console.WriteLine(color);

// UnionBy
//var students = Student.GetStudents();
//var studentsTwo = new List<Student> 
//{ 
//    new Student { Id = 1, Name = "Hasan", Age = 47 },
//    new Student { Id = 2, Name = "Ali", Age = 16 },
//    new Student { Id = 3, Name = "Ahmed", Age = 47 },
//};

//var unionByByResult = students.UnionBy(studentsTwo, s => s.Age);
//foreach (var student in unionByByResult)
//    Console.WriteLine(student.ToString());


Console.ReadKey();
