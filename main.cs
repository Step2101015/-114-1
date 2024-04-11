/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        string str = "Hello, World!";
        char firstChar = str[0];
        char lastChar = str[str.Length - 1];

        str = lastChar + str.Substring(1, str.Length - 2) + firstChar;

        Console.WriteLine(str);
    }
}
