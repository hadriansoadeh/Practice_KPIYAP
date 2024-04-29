using System;

enum EmployeePosition
{
    Manager, 
    Assistant, 
    Developer, 
    Trainee 
}

class Accountant
{
    
    public bool AskForBonus(EmployeePosition position, int hoursWorked)
    {
        Console.WriteLine("Введите пороговое значение отработанных часов для премии");
        int BonusThresholdHours = int.Parse(Console.ReadLine()); 

        
        if (hoursWorked > BonusThresholdHours)
        {
            Console.WriteLine($"Сотруднику с должностью {position} положена премия!");
            return true;
        }
        else
        {
            Console.WriteLine($"Сотруднику с должностью {position} премия не положена.");
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        
        Accountant accountant = new Accountant();

        
        bool bonusGranted = accountant.AskForBonus(EmployeePosition.Assistant, 170);
        


        if (bonusGranted)
        {
            Console.WriteLine("Премия была начислена.");
        }
        else
        {
            Console.WriteLine("Премия не была начислена.");
        }
    }
}
