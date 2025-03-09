using System;

class Employee
{
    public int Id;
    public string Name;
    public double Salary;
    public string Department;

    public Employee(int id, string name, double salary, string department)
    {
        Id = id;
        Name = name;
        Salary = salary;
        Department = department;
    }

    public virtual double CalculateBonus()
    {
        return 0;
    }
}

class Manager : Employee
{
    public int TeamSize;

    public Manager(int id, string name, double salary, string department, int teamSize)
        : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.2;
    }
}

class Developer : Employee
{
    public string About;

    public Developer(int id, string name, double salary, string department, string about)
        : base(id, name, salary, department)
    {
        About = about;
    }

    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }
}

class BankAccount
{
    public string AccountHolder;
    public double Balance;

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public virtual void CalculateInterest()
    {
        Console.WriteLine("Interest calculation not defined.");
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, double balance) : base(accountHolder, balance) { }

    public override void CalculateInterest()
    {
        double interest = Balance * 0.05;
        Console.WriteLine($"Interest earned: {interest}");
    }
}

class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, double balance) : base(accountHolder, balance) { }

    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager(1, "Ali", 5000, "IT", 10);
        Developer developer = new Developer(2, "Ayşe", 4000, "Software", "C# Developer");

        Console.WriteLine($"Manager Bonus: {manager.CalculateBonus()}");
        Console.WriteLine($"Developer Bonus: {developer.CalculateBonus()}");

        SavingsAccount savings = new SavingsAccount("Mehmet", 10000);
        CheckingAccount checking = new CheckingAccount("Fatma", 5000);

        savings.CalculateInterest();
        checking.CalculateInterest();
    }
}
