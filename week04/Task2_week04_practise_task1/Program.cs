using Task2_week04_practise_task1.Models;

namespace Task2_week04_practise_task1;

internal class Program
{
    static void Main()
    {
        string input;
        bool isCompany = false;
        Company company = new Company(null);

        do
        {
            Console.WriteLine("\n" + company + " Company Lobby.");
            Console.WriteLine("1. Create a company");
            Console.WriteLine("2. Create an employee");
            Console.WriteLine("3. Delete employee");
            Console.WriteLine("4. Update employee");
            Console.WriteLine("5. See all employees");
            Console.WriteLine("6. See employee");
            Console.WriteLine("7. End program.");
            Console.Write("You may choose action: ");
            input = Console.ReadLine();

            if (!(isCompany || input == "1" || input == "7"))
            {
                Console.WriteLine("First create company");
                continue;
            }

            switch (input)
            {
                case "1":
                    Console.Write("Name of company will be: ");
                    input = Console.ReadLine();

                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        company = new Company(input);
                        isCompany = true;
                    }
                    break;
                case "2":
                    Console.Write("Age of employee: ");
                    Byte.TryParse(Console.ReadLine(), out byte Age);

                    Console.Write("Name of employee: ");
                    input = Console.ReadLine();

                    Console.Write("Surname of employee: ");
                    company.AddUser(new Employee(input, Console.ReadLine(), Age));
                    break;
                case "3":
                    Console.Write("Give name of user: ");
                    company.RemoveUser(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Give name of user you will update: ");
                    company.UpdateUser(Console.ReadLine());
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
                    Console.WriteLine(company.GetUser(Console.ReadLine()));
                    break;
                case "7":
                    return;
                default:
                    break;
            }
        } while (true);
    }
}