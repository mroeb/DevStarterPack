// https://github.com/mroeb/DevStarterPack.git
// 8. Prime Number Check

bool isPrimeNumber(int number)
{
    if ( number <= 1 )
    {
        return false;
    }

    for ( int i = 2 ; i <= number / 2 ; i++ )
    {
        if ( number % i == 0 )
        {
            return false;
        }
    }

    return true;
}

Console.WriteLine(isPrimeNumber(1)); // false
Console.WriteLine(isPrimeNumber(2)); // true
Console.WriteLine(isPrimeNumber(3)); // true
Console.WriteLine(isPrimeNumber(4)); // false
Console.WriteLine(isPrimeNumber(5)); // true