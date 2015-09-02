/*
 * PermMissingElem
 * Find the missing element in a given permutation. 
 * language: C#
 * my result: 70% https://codility.com/demo/results/demo2BRA3Q-UF9/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = {2,3,1,5};
            Console.WriteLine(solution(pole));
            Console.ReadKey();
        }
        public static int solution(int[] A)
        {
	    int rsum = A.Sum();
            int nsum = ((A.Length+1) * (1 + (A.Length+1))) / 2;
            int length = A.Length;
            int res = nsum - rsum;
            return res;
        }
    }
}
