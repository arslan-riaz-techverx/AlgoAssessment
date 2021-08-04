using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
    public static class  Lib
    {
        public static string RemoveSpacesSpecialCharacters(string input)
        {
            return Regex.Replace(input, @"[^A-Za-z]", string.Empty);
        }
        public static readonly HashSet<char> VowelsLetter = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
    }
}
