using Microsoft.VisualBasic;
using Task2_week04_practise_task1.Models;

namespace Task2_week04_practise_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool isCompany = false;
            Company company = new Company("null");

            do
            {
                Console.WriteLine("\n1. Create a company");
                Console.WriteLine("2. Create an employee");
                Console.WriteLine("3. Delete employee");
                Console.WriteLine("4. Update employee");
                Console.WriteLine("5. See all employees");
                Console.WriteLine("6. See employee");
                Console.WriteLine("7. End program.");
                Console.Write("You may choose action: ");
                input = Console.ReadLine();

                if (!(isCompany && input == "1"))
                {
                    Console.WriteLine("First create company");
                    continue;
                }

                switch (input)
                {
                    case "1":
                        Console.Write("Name of company will be: ");
                        input = Console.ReadLine();
                        company = new Company(input);
                        isCompany = true;
                        break;
                    case "2":
                        Console.Write("Name of employee: ");
                        input = Console.ReadLine();

                        Console.Write("Surname of employee: ");
                        string input2 = Console.ReadLine();

                        Console.Write("Age of employee: ");
                        byte Age = Convert.ToByte(Console.ReadLine());

                        company.AddUser(new Employee(input, input2, Age));
                        break;
                    case "3":
                        Console.Write("Give name of user: ");
                        input = Console.ReadLine();
                        company.RemoveUser(input);
                        break;
                    case "4":
                        Console.Write("Give name of user you will update: ");
                        input = Console.ReadLine();
                        company.UpdateUser(input);
                        break;
                    case "5":
                        Employee[] users = company.GetAllUsers();
                        for (int i = 0; i < users.Length; i++)
                        {
                            Console.WriteLine(users[i]);
                        }
                        break;
                    case "6":
                        Console.Write("Give name of user: ");
                        input = Console.ReadLine();
                        Console.WriteLine(company.GetUser(input));
                        break;
                    case "7":
                        return;
                    default:
                        break;
                }
            } while (true);






            //Company Company1 = new Company("JafarTech");
            ////
            //Employee Employee1 = new Employee("Jafar", "Mustafazade", 19);
            //Console.WriteLine("\ntesting1." + Employee1.Username);
            //Company1.AddUser(Employee1);
            ////
            //Company1.RemoveUser(Employee1.Username);
            //Company1.RemoveUser(Employee1.Username);
            ////
            //Company1.AddUser(Employee1);
            //Company1.UpdateUser(Employee1.Username);
            ////
            //Company1.AddUser(Employee1);
            //Employee[] Employees = Company1.GetAllUsers();
            //for (int i = 0; i < Employees.Length; i++)
            //{
            //    Console.WriteLine("[" + i + "]: " + Employees[i].Username);
            //}
            ////
            //Console.WriteLine("testing2." + Company1.GetUser(Employee1.Username).Username);
        }
    }
}