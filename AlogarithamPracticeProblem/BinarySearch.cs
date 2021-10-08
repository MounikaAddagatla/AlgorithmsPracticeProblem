using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace AlogarithamPracticeProblem
{
    class BinarySearch
    {
        string[] arr;
        public BinarySearch(string[] arr)
        {
            this.arr = arr;
            Array.Sort(this.arr);
        }
        public int FindWord(string word, int min, int max)
        {
            int mid = min;
            while (min < max)
            {
                mid = (min + max) / 2;
                if (arr[mid] == word)
                {
                    return 1;
                }
                else if (arr[mid].CompareTo(word) > 0)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (arr[mid] != word)
            {
                return 0;
            }
            else
            {
                return 0;
            }
        }
    }
}
