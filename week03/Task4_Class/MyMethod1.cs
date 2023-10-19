using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Class
{
    public class User
    {
        public string UserName;
        public string Password;
        public string Token;
        public string[] DataBase;
        public User(string[] database) 
        {
            this.UserName = "Guest";
            this.Password = "";
            this.Token = "";
            this.DataBase = database;
        }
        public User(string[] database, string username, string password) : this(database)
        {
            this.UserName = username;
            this.Password = password;
        }
        
        public string SimpleTokenMaker(string username, string password)
        {
            bool isDevMod = false;
            int seed = 0;

            for (int c = 0; c < password.Length; c++)
            {
                seed += password[c];
            }
            for (int c = 0; c < username.Length; c++)
            {
                seed += username[c];
            }

            seed = (seed * 73129 + (9 * username.Length)) % (password.Length * 1111 + 1);

            if (isDevMod) Console.WriteLine("c" + seed);
            return "c" + seed;
        }
        public void Register(ref string[] database) 
        { 
            this.Register(ref database, this.UserName, this.Password);
        }
        public void Register(ref string[] NewDataBase, string username, string password)
        {
            if(NewDataBase.Length < 1)
            {
                NewDataBase = new string[2];
                NewDataBase[0] = username;
                NewDataBase[1] = this.SimpleTokenMaker(username,password);
                this.DataBase = NewDataBase;
            }
            else
            {
                for (int c = 0; c < NewDataBase.Length; c += 2) 
                {
                    if (username == NewDataBase[c])
                    {
                        Console.WriteLine("Already registered.");
                        this.DataBase = NewDataBase;
                        return;
                    }
                }

                NewDataBase = new string[NewDataBase.Length + 2];

                for (int c = 0; c < NewDataBase.Length; c++)
                {
                    NewDataBase[c] = NewDataBase[c];
                }

                NewDataBase[NewDataBase.Length] = this.SimpleTokenMaker(username,password);
                NewDataBase[NewDataBase.Length + 1] = username;
                this.DataBase = NewDataBase;
            }

            Console.WriteLine("Registered " + username);
        }
        public void Login()
        {
            if (this.Token.Length > 0)
            {
                Console.WriteLine("istifadəçi öncədən hesaba daxil olub"); // ulduz
            }
            else
            {
                string token = this.SimpleTokenMaker(this.UserName, this.Password);
                for (int c = 0; c < this.DataBase.Length; c += 2) 
                {
                    if (this.UserName == this.DataBase[c] && token == this.DataBase[c + 1]) 
                    {
                        this.Token = token;
                        Console.WriteLine("istifadəçi hesaba daxil oldu"); // ulduz
                        return;
                    }
                }
                Console.WriteLine("No such person or wrong password.");
            }
        }
        public void Login(string username, string password)
        {
            this.UserName = username;
            this.Password = password;

            this.Login();
        }
        public void Logout()
        {
            if (this.Token.Length > 0)
            {
                this.Token = "";
                Console.WriteLine("istifadəçi hesabdan çıxış etdi"); // ulduz
            }
            else
            {
                Console.WriteLine("istifadəçi hesaba giriş etməyib"); // ulduz
            }
        }
    }
}
