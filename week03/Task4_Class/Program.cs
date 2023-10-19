namespace Task4_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] DataBase = new string[0];
            User FirstAdmin = new User(DataBase,"admin","123");
            User ZorJafar = new User(DataBase,"admin","123");

            FirstAdmin.Register(ref DataBase);
            FirstAdmin.Register(ref DataBase);
            ZorJafar.Register(ref DataBase);
            Console.WriteLine();

            FirstAdmin.Login();
            FirstAdmin.Login();
            ZorJafar.Login();
            Console.WriteLine();

            FirstAdmin.Logout();
            FirstAdmin.Logout();
            ZorJafar.Logout();
            Console.WriteLine();
        }
    }
}