using System;
using System.Linq;
using System.Collections.Generic;

public class Brace
{
    public static bool validBraces(String braces)
    {
        Console.WriteLine(braces);

        Stack<char> bracesStack = new Stack<char>(); // stack is the best way to keep a track of the brace
        foreach (var item in braces.ToCharArray())
        {
            if (item == '(' || item == '{' || item == '[')
            {
                bracesStack.Push(item);
            }
            else if (item == ')' || item == '}' || item == ']')
            {
                if (bracesStack.Count == 0) // if the we try to close something who as been never opened.
                {
                    return false;
                }
                if (bracesStack.Pop() != GetComplementBracket(item)) // if this is not the complement we have an error.
                {
                    return false;
                }
            }
        }
        if (bracesStack.Count == 0) // if the we try to close something who as been never opened.
        {
            return true;
        }
        return false;
    }

    /// return the complement of the left bracket
    private static char GetComplementBracket(char item)
    {
        switch (item)
        {
            case ')':
                return '(';
            case '}':
                return '{';
            case ']':
                return '[';
            default:
                return ' ';
        }
    }
}