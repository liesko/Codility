/*
 * TapeEquilibrium
 * my result: 83% https://codility.com/demo/results/demo9JTERA-FDU/ 
 * tak: Minimize the value |(A[0] + ... + A[P-1]) - (A[P] + ... + A[N-1])|. 
 * language: C#
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3,1,2,4,3 };
            Console.WriteLine(solution(A));
            Console.ReadKey();
        }
        public static int solution(int[] A)
        {
            int i=0;
            int diference=0;
            int sumA = 0;
            int sumB = A.Sum();

            while (i < A.Length)
            {
                sumA += A[i];
                sumB -= A[i];
                if (i == 1) 
                {
                    diference = Math.Abs(sumA - sumB);
                }
                diference=(Math.Abs(sumA-sumB)<diference)?Math.Abs(sumA-sumB):diference;
                
                i++;
            }
                return diference;
        }
    }
}
