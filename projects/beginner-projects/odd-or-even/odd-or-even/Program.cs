// https://github.com/mroeb/DevStarterPack
// 3. odd or even

string input = "";

Console.WriteLine("Enter a number: ");
input = Console.ReadLine();

int number = Convert.ToInt32(input);



// check if the number is even or odd (hint: use the modulo operator)
if ( number % 2 == 0 )
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}