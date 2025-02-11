// https://github.com/mroeb/DevStarterPack.git
// 7. Palindrome Check

bool IsPalindrome(string str)
{
    int left = 0;
    int right = str.Length - 1;

    while ( left < right )
    {
        if ( str[ left ] != str[ right ] )
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
}

Console.WriteLine(IsPalindrome("racecar")); // True
Console.WriteLine(IsPalindrome("hello")); // False