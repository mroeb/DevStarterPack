// https://github.com/mroeb/DevStarterPack
// 2. Sum-of-tow-numbers

string userIn = "";

double number1 = 0;
double number2 = 0;
double sum = 0;

Console.WriteLine("Enter the first number: ");
userIn = Console.ReadLine();

number1 = Convert.ToDouble(userIn);

Console.WriteLine("Enter the second number: ");
userIn = Console.ReadLine();

number2 = Convert.ToDouble(userIn);

sum = number1 + number2;


Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + sum);