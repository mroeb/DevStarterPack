// https://github.com/mroeb/DevStarterPack.git
// 5. Factorial

static int factorial (int n)
{
    int result = 1;

    for(int i = 1 ; i <= n ; i++ )
    {
        result *= i;
    }
    return result;

}

Console.WriteLine(factorial(5)); // 120