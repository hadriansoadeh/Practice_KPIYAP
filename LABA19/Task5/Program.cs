/// <summary>
 /// Класс, представляющий группу студентов.
 /// </summary>
 namespace Task5
{ 
    class StudentGroup
    {
        private List<Student> students = new List<Student>();

        /// <summary>
        /// Добавляет студента в группу.
        /// </summary>
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        /// <summary>
        /// Удаляет студента из группы.
        /// </summary>
        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        /// <summary>
        /// Ищет студента по фамилии.
        /// </summary>
        public Student FindStudentByLastName(string lastName)
        {
            return students.Find(s => s.LastName == lastName);
        }

        /// <summary>
        /// Сортирует студентов по имени.
        /// </summary>
        public void SortStudentsByName()
        {
            students.Sort((s1, s2) => string.Compare(s1.FirstName, s2.FirstName));
        }

        /// <summary>
        /// Возвращает студента по индексу.
        /// </summary>
        public Student GetStudentByIndex(int index)
        {
            if (index >= 0 && index < students.Count)
                return students[index];
            else
                return null;
        }
    }


    /// <summary>
    /// Класс, представляющий студента.
    /// </summary>
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }


    static void Main(string[] args)
    {
        var group = new StudentGroup();

        group.AddStudent(new Student("Иван", "Иванов", new DateTime(2000, 5, 10)));
        group.AddStudent(new Student("Петр", "Петров", new DateTime(2001, 8, 15)));

        var foundStudent = group.FindStudentByLastName("Иванов");
        if (foundStudent != null)
        {
            Console.WriteLine($"Найден студент: {foundStudent.FirstName} {foundStudent.LastName}");
        }

        group.SortStudentsByName();

        var studentAtIndex = group.GetStudentByIndex(1);
        if (studentAtIndex != null)
        {
            Console.WriteLine($"Студент по индексу 1: {studentAtIndex.FirstName} {studentAtIndex.LastName}");
        }

        Console.ReadLine();
    }
}