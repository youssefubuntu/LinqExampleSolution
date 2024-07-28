namespace SetOperationsExample
{
    public class Student
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required byte Age { get; set; }

        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student { Id = 1, Name = "Mazen", Age = 21 },
                new Student { Id = 2, Name = "Basem", Age = 27 },
                new Student { Id = 3, Name = "Salah", Age = 21 },
                new Student { Id = 4, Name = "Osama", Age = 36 },
                new Student { Id = 5, Name = "Mazen", Age = 21 },
                new Student { Id = 6, Name = "Ahmed", Age = 19 },
                new Student { Id = 7, Name = "Mazen", Age = 18 },
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
