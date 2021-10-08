using System;
using System.Collections.Generic;
using System.Text;

namespace AlogarithamPracticeProblem
{
    class Permutations
    { 
            public static void Permute(String str, int l, int r)
            {
                if (l == r)
                    Console.WriteLine(str);
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = Swap(str, l, i);
                        Permute(str, l + 1, r);
                        str = Swap(str, l, i);
                    }
                }
            }
            public static String Swap(String a, int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }
        
    }
}
