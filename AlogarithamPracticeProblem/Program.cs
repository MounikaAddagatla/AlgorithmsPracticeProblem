using System;

namespace AlogarithamPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Algorithem Practice problems");
            int options;
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("choose 1.PermutationOfString ");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Enter a string");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutations.Permute(str, 0, n - 1);
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
