// https://github.com/mroeb/DevStarterPack.git
// 10. Count Vowels

int CountVowels(string str)
{
    int count = 0;
    foreach ( char c in str )
    {
        if ( "aeiou".Contains(c) )
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine(CountVowels("hello")); // 2 (e, o)
Console.WriteLine(CountVowels("why")); // 0