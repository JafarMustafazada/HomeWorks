using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    internal class loop_task1
    {
        public void Run()
        {
            // input values
            int givenNumb1;
            // temporary values
            int temp1;
            bool temp_bool;

            for (int j = -102; j < 1026; j++)
            {
                givenNumb1 = j;
                temp_bool = true;

                // #check if number is prime ////////////////////////////////////////////////////////////////
                if (givenNumb1 > 1)
                {
                    for (int i = 2; i <= givenNumb1 / 2; i++)
                    {
                        if (givenNumb1 % i == 0)
                        {
                            temp_bool = false;
                            break;
                        }
                    }
                }
                else
                {
                    temp_bool = false;
                }

                if (temp_bool)
                {
                    Console.WriteLine("\n1.Given number is indeed prime number.");
                }
                else
                {
                    Console.WriteLine("\n0.Given number is not prime.");
                }



                // #define if given number is power of 2 ////////////////////////////////////////////////////////////////
                /*
                 normally this kind of number is: 1 and 00000000 like 2 -> 10, 4 -> 100, 8 -> 1000 and etc.
                 what means if we -1 from it it will be: 0 and 111111111111
                 and if we & it with original: 1000 & 0111 -> result always will be 0000.
                */
                //temp_bool = ((givenNumb1 & (givenNumb1 - 1)) == 0 && givenNumb1 > 0);

                temp1 = givenNumb1;

                while (temp1 % 2 == 0 && temp1 != 0)
                {
                    temp1 /= 2;
                }
                temp_bool = (temp1 == 1);

                if (temp_bool)
                {
                    Console.WriteLine("1.Given number is indeed power of 2.");
                }
                else
                {
                    Console.WriteLine("0.Given number is not power of 2.");
                }



                // #calculate level of number ////////////////////////////////////////////////////////////////
                if (givenNumb1 < 0) givenNumb1 *= -1;

                temp1 = 0;
                do
                {
                    temp1++;
                    givenNumb1 /= 10;
                } while (givenNumb1 > 0);

                Console.WriteLine(temp1 + " is level of number -> " + j);



                for (int i = 0; i < 16; i++)
                {
                    Console.Write("//");
                }
            }
        }
    }
}
