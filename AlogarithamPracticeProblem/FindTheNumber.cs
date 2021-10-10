using System;
using System.Collections.Generic;
using System.Text;

namespace AlogarithamPracticeProblem
{
    class FindTheNumber
    {
        int start = 1;
        int end = 100;
        public int FindMid()
        {
            int mid = (start + end) / 2;
            return mid;
        }
        public void CheckNumber(int mid)
        {
            //get the input from user
            Console.WriteLine("1.Is your number is greater than {0}\n2. Is your Number is less than equal to {0}", mid, mid);
            Console.Write("Enter your option : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    start = mid + 1;
                    break;
                case 2:
                    end = mid;
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        public void Guess()
        {
            while (start != end)
            {
                int mid = FindMid();
                CheckNumber(mid);
            }
            if (start == end)
            {
                Console.WriteLine("The guess number is {0}", start);
            }
        }
    }
}
