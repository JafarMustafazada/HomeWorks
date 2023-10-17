namespace Task2_Methods
{
    internal class Program
    {
        static void Main()
        {
            int Radius = 2, SideA = 1, SideB = 2, SideC = 3;
            Console.WriteLine(Area(Radius) + " -> circle");
            Console.WriteLine(Area(SideA, SideB) + " -> rectangle");
            Console.WriteLine(Area(SideA, SideB, SideC) + " -> rectangular parallelepiped");
            Console.WriteLine(Area(Radius, SideA, SideB, SideC) + " -> circle in triangle");

            int num1 = 2, num2 = 3;
            char opr = '/';
            // a.
            Console.WriteLine("result -> " + calc(num1, num2, opr));
            // b.
            Console.WriteLine(pow(num2) + " -> power of n2");
            Console.WriteLine(pow(num1, num2) + " -> power of n1, n2 times");
            // c.
            welcome("Jafar", "Mustafazade", "Elshan");
            Console.WriteLine();
            welcome("Jafar", "Mustafazade");
            Console.WriteLine();
            // cout << endl << endl;
        }
        // overload tasks
        static int Area(int r)
        {
            return 2 * 3 * r * r;
        }
        static int Area(int a, int b)
        {
            return a * b;
        }
        static int Area(int a, int b, int c)
        {
            return 2 * (a * b + b * c + a * c);
        }
        static int Area(int r, int a, int b, int c)
        {
            return (a + b + c) * r / 2;
        }
        static string calc(int x, int y, char operation)
        {
            switch (operation)
            {
                case '+':
                    return "" + (x + y);
                case '-':
                    return "" + (x - y);
                case '*':
                    return "" + (x * y);
                case '/':
                    return "" + ((double)x / y);
                default:
                    return "null";
            }
        }
        static int pow(int x, int y = 2)
        {
            int power = x;
            for (int i = 1; i < y; i++)
            {
                power *= x;
            }
            return power;
        }
        static void welcome(string name)
        {
            Console.Write(name);
        }
        static void welcome(string name, string surname)
        {
            welcome(name);
            Console.Write(" " + surname);
        }
        static void welcome(string name, string surname, string ataAd)
        {
            Console.Write(name[0] + "." + surname + " " + ataAd);
        }
    }
}