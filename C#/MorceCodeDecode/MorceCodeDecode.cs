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
            string[] letters = words[i].Split(' ');// ..
            for (int y = 0; y < letters.Length; y++)
            {
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