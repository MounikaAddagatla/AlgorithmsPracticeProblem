using System;
namespace AlogarithamPracticeProblem
{
    class InsertionSort
    {
        public void Sort(string[] textArr)
        {
            string max;
            for (int i = 1; i < textArr.Length; i++)
            {
                max = textArr[i];
                int j = i - 1;
                while (j >= 0 && textArr[j].CompareTo(max) > 0)
                {
                    textArr[j + 1] = textArr[j];
                    j--;
                }
                textArr[j + 1] = max;
            }
        }
        public void Display(string[] textArr)
        {
            for (int i = 0; i < textArr.Length; i++)
            {
                Console.WriteLine(textArr[i]);
            }
        }
    }
}
