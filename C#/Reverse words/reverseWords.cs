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
            if (i < words.Length - 1) // and add a space if its the last word
            {
                result += " ";
            }
        }
        return result;
    }
}

// ----------------------- Best Solution :  --------------------

// using System;
// using System.Linq;

// public static class Kata
// {
//   public static string ReverseWords(string str)
//   {
//     return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
//   }
// }