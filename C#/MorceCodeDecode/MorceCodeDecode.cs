using System;
using System.Linq;
class MorseCodeDecoder
{
    public static string Decode(string morseCode) // .. -. -.   .- .- .--
    {
        string result = "";
        string[] words = morseCode.Split("   "); // .. -. -.
        for (int i = 0; i < words.Length; i++)
        {
            if(words[i] == String.Empty){
                continue;
            }

            string[] letters = words[i].Split(' ');// ..
            for (int y = 0; y < letters.Length; y++)
            {
                Console.WriteLine(letters[y]);
                result += MorseCode.Get(letters[y]);
            }
            if (i < words.Length - 1)
            {
                result += " ";
            }
        }
        return result;
    }
}

// ------------------------- BEST SOLUTION -----------------------
// using System;
// using System.Linq;

// class MorseCodeDecoder
// {
//   public static string Decode(string morseCode)
//   {
//     var words = morseCode.Trim().Split(new[] {"   "}, StringSplitOptions.None);
//     var translatedWords = words.Select(word => word.Split(' ')).Select(letters => string.Join("", letters.Select(MorseCode.Get))).ToList();
//     return string.Join(" ", translatedWords);
//   }
// }

// I need to improve my Linq knowledge.