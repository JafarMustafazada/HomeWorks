
// Fibonacci task
int numberX = 101;
int temporary = 0;
int fibonacci = 1;

while (fibonacci < numberX)
{
    Console.Write(fibonacci + ",");
    fibonacci += temporary;
    temporary = fibonacci - temporary;
}
Console.WriteLine(fibonacci);



// Swaping task
int num1 = 14;
int num2 = 9;

num1 += num2;
num2 = num1 - num2;
num1 -= num2;

Console.WriteLine(num1 + " - " + num2);
