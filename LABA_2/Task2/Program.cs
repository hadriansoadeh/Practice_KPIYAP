namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Worker : Person
    {
        public string Company { get; set; }
        public int Salary { get; set; }
    }

    class Engineer : Worker
    {
        public string Specialization { get; set; }
    }

    class Employee : Person
    {
        public string Department { get; set; }
        public int Salary { get; set; }
    }
}