using System;
using System.IO;

namespace AlogarithamPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome To Algorithem Practice problems ");
            int options;
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("choose \n1.PermutationOfString \n2. BubbleSort \n3. InsertionSort");
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
                    case 2:
                        string filepath = @"E:\AlgorithmsPracticeProblem\AlogarithamPracticeProblem\WordFile\Word.txt";
                        string text = File.ReadAllText(filepath);
                        string[] textArray = text.Split(" ");
                        BinarySearch binarySearch = new BinarySearch(textArray);
                        Console.WriteLine("Enter a word to search:");
                        string word = Console.ReadLine();
                        int found = binarySearch.FindWord(word, 0, textArray.Length - 1);
                        if (found == 1)
                        {
                            Console.WriteLine("The word {0} is found", word);
                        }
                        else
                        {
                            Console.WriteLine("the word {0} is not found", word);
                        }
                        break;
                    case 3:
                        string filepathins = @"E:\AlgorithmsPracticeProblem\AlogarithamPracticeProblem\WordFile\Word.txt";
                        string sort = File.ReadAllText(filepathins);
                        string[] sortArray = sort.Split(" ");
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Sort(sortArray);
                        insertionSort.Display(sortArray);
                        break;
                    case 4:
                        int[] arr = { 5, 7, 1, 3, 60, 12, 68 };
                        BubbleSort bubbleSort = new BubbleSort();
                        arr = bubbleSort.Sort(arr);
                        bubbleSort.Display(arr);
                        break;
                    default:
                        Console.WriteLine("Exit");
                        break;
                }
            }
        }
    }
}
