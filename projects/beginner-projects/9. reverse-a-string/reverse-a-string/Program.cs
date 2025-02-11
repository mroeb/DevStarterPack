// https://github.com/mroeb/DevStarterPack.git
// 9. Reverse a string

string reverseString(string str)
{
    string reversed = "";
    for ( int i = str.Length - 1 ; i >= 0 ; i-- )
    {
        reversed += str[ i ];
    }
    return reversed;
}

Console.WriteLine(reverseString("Hello World!"));
