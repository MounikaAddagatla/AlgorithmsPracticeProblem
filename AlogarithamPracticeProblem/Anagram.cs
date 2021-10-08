using System;
using System.Collections.Generic;
using System.Text;

namespace AlogarithamPracticeProblem
{
    class Anagram
    {
        public void CheckAnagram(string str1, string str2)
        {
            char[] char1 = str1.ToCharArray();
            char[] char2 = str2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            String s1 = new String(char1);
            String s2 = new String(char2);

            if (s1.Equals(s2))
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
    }
}
