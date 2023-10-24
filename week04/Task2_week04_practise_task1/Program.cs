using Task2_week04_practise_task1.Models;

namespace Task2_week04_practise_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company Company1 = new Company("JafarTech");
            //
            Employee Employee1 = new Employee("Jafar", "Mustafazade", 19);
            Console.WriteLine("testing1." + Employee1.Username);
            Company1.AddUser(Employee1);
            //
            Company1.RemoveUser(Employee1.Username);
            Company1.RemoveUser(Employee1.Username);
            //
            Company1.AddUser(Employee1);
            Company1.UpdateUser(Employee1.Username);
            //
            Company1.AddUser(Employee1);
            Employee[] Employees = Company1.GetAllUsers();
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine("[" + i + "]: " + Employees[i].Username);
            }
            //
            Console.WriteLine("testing2." + Company1.GetUser(Employee1.Username).Username);
        }
    }
}