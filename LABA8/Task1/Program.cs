using System;

struct STUDENT
{
    public string LastNameAndInitials;
    public int GroupNumber;
    public int[] Performance;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите кол-во студентов");
        int NumStudents = int.Parse(Console.ReadLine());
        STUDENT[] students = new STUDENT[NumStudents];

        
        for (int i = 0; i < NumStudents; i++)
        {
            Console.WriteLine($"Введите данные студента {i + 1}:");

           
            Console.Write("Фамилия и инициалы: ");
            students[i].LastNameAndInitials = Console.ReadLine();

            
            Console.Write("Номер группы: ");
            students[i].GroupNumber = int.Parse(Console.ReadLine());

            
            students[i].Performance = new int[5];
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Введите оценку {j + 1}: ");
                students[i].Performance[j] = int.Parse(Console.ReadLine());
            }
        }

       
        Array.Sort(students, (s1, s2) =>
        {
            double avg1 = s1.Performance.Average();
            double avg2 = s2.Performance.Average();
            return avg1.CompareTo(avg2);
        });

        
        bool found = false;
        foreach (var student in students)
        {
            double avgGrade = student.Performance.Average();
            if (avgGrade >= 4)
            {
                Console.WriteLine($"Студент: {student.LastNameAndInitials}, Группа: {student.GroupNumber}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Нет студентов с оценками 4 и 5.");
        }
    }
}
