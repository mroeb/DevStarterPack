// https://github.com/mroeb/DevStarterPack
// 4. largest of three numbers

double number1 = 0;
double number2 = 0;
double number3 = 0;

Console.WriteLine("Enter the first number: ");
number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
number2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
number3 = Convert.ToDouble(Console.ReadLine());

double max = number1;

if( number2 > max )
{
    max = number2;
}
if( number3 > max )
{
    max = number3;
}

Console.WriteLine("The largest number is: " + max);

