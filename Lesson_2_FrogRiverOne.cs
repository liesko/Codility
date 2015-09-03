/*
 * My result: 90% https://codility.com/demo/results/demoE6ANWA-TBM/ 
 * language: C#
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1 };
            //int[] A = { 1, 3, 1, 14,14,14,23,234,4,3,3,3, 2, 3, 5, 4 };
            //int[] A = { 1, 3, 1, 4,2,3,5,4 }; 
            Console.WriteLine("-------------");
            Console.WriteLine(solution(1, A));

            Console.ReadKey();
        }
        public static int solution(int X, int[] A)
        {
            int counter=0;
            int[] second_arr = new int[A.Length];
            Array.Clear(second_arr, 0, second_arr.Length);
            int minute = 0;
            int spolu = 0;

            while (counter < A.Length - 1)
            {
                if((A[counter]<=X)&&(second_arr[A[counter]]==0))
                {
                    second_arr[A[counter]] = 1;
                    spolu++;
                    if (spolu == X) 
                    {
                        return minute++;
                    }
                }
                minute++;
                counter++;
            }
            if ((A.Length==1)&&(A[0] == 1))
            {
                return 0;
            }
            return -1;
        }
    }
}
