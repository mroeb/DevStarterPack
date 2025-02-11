// https://github.com/mroeb/DevStarterPack.git
// 6. Fibonacci Sequence

static int Fibonacci(int n)
{
    if ( n <= 1 )
    {
        return n;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

Console.WriteLine(Fibonacci(10)); // 55