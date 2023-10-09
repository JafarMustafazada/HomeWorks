// input values
int givenNumb1 = 1024;

for (int j = 0; j < 1026; j++)
{
    givenNumb1 = j;

    // helping values
    int temp1 = 0;
    bool checker = true;

    // 1 2 3 5 7 11 13 17

    // #check if number is prime
    if (givenNumb1 > 1)
    {
        for (int i = 2; i <= givenNumb1 / 2; i++)
        {
            if (givenNumb1 % i == 0)
            {
                checker = false;
                break;
            }
        }
    }
    else
    {
        checker = false;
    }

    if (checker)
    {
        Console.WriteLine("1.Given number is indeed prime number.");
    }
    else
    {
        Console.WriteLine("0.Given number is not prime.");
    }



    // #define if given number is power of 2

    // normally this kind of number is: 1 and 00000000 like 2 -> 10, 4 -> 100, 8 -> 1000 and etc.
    // what means if we -1 from it it will be: 0 and 111111111111
    // and if we & it with original: 1000 & 0111 -> result always will be 0000.

    checker = ((givenNumb1 & (givenNumb1 - 1)) == 0 && givenNumb1 > 0);

    // here you go loop method also:
    //temp1 = givenNumb1;

    //while(temp1 % 2 == 0)
    //{
    //    temp1 /= 2;
    //}

    //checker = (temp1 == 1);

    if (checker)
    {
        Console.WriteLine("1.Given number is indeed power of 2.");
    }
    else
    {
        Console.WriteLine("0.Given number is not power of 2.");
    }



    // #calculate level of number
    temp1 = 0;
    do
    {
        temp1++;
        givenNumb1 /= 10;
    } while (givenNumb1 > 0);

    Console.WriteLine(temp1 + "\t" + j);
    // more interesting do_while task will be like: check if user input 'good', if not request another input until it 'good'.
}