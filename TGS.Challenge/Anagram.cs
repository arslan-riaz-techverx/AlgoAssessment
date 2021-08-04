using System;
using System.Linq;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
            if (!string.IsNullOrEmpty(word1) && !string.IsNullOrEmpty(word2))
            {
                word1=Lib.RemoveSpacesSpecialCharacters(word1);
                word2 = Lib.RemoveSpacesSpecialCharacters(word2);
                return string.Concat(word1.ToUpper().OrderBy(x => x)).Equals(string.Concat(word2.ToUpper().OrderBy(x => x)));
            }
            else
            {
                throw new ArgumentException("One word or two words are coming empty, Please write words");
            }
          
      }
    }
}
