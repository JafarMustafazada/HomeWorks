using Task1_AccessModifiers.Models;

namespace Task1_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crap interface
            Console.Write("How many notebooks of doom will be summoned, director Jafar?: ");
            // Assume, no take it as fact, Jafar cant give other than right value:
            string input = Console.ReadLine();
            int HowManyNotes = Convert.ToInt32(input);
            NoteBook[] notebooks = new NoteBook[HowManyNotes];
            int PreviusIndex = -1;

            for (int i = 0; i < HowManyNotes; i++)
            {
                notebooks[i] = new NoteBook(1,0,"Jhonny+9");
                Console.WriteLine();

                while (!notebooks[i].checker())
                {
                    if (PreviusIndex == i)
                    {
                        Console.WriteLine("\nTry again.");
                    }

                    Console.Write("[" + i + "] Give name of Brand: ");
                    input = Console.ReadLine();
                    notebooks[i].Brand = input;

                    Console.Write("[" + i + "] Give RAM capacity: ");
                    input = Console.ReadLine();
                    notebooks[i].RAM = Convert.ToInt32(input);

                    Console.Write("[" + i + "] Give storage capacity: ");
                    input = Console.ReadLine();
                    notebooks[i].Storage = Convert.ToInt32(input);

                    Console.Write("[" + i + "] Give price: ");
                    input = Console.ReadLine();
                    notebooks[i].Price = Convert.ToInt32(input);

                    PreviusIndex = i;
                }
            }
            Console.WriteLine("Done.");
        }
    }
}