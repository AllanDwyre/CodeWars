using System;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        string[] words = str.Split(' '); // we get the words
        string result = "";
        for (int i = 0; i < words.Length; i++) // for each words
        {
            char[] itemChar = words[i].ToCharArray(); // we reverse them
            Array.Reverse(itemChar);
            result += new string(itemChar);
            if (i < words.Length - 1) // and add a space if its the
            {
                result += " ";
            }
        }
        return result;
    }
}