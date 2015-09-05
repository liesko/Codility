/*
* codility train: Lesson_2_PermCheck
* my result: 80% https://codility.com/demo/results/demoZW74UZ-C6G/ 80 percent
* language: C#
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_PermCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            int[] A = { 4, 1,3,2 };

            Console.WriteLine("=========================");
            Console.WriteLine(solution(A));
            Console.ReadKey();
        }
        public static int solution(int[] A)
        {
            int result = 0;
            Array.Sort(A);

                if (A.Last() == A.Length)
                {
                    result = 1;
                }
            return result;
        }
        
            // 60 percent
        //public static int solution(int[] A)
        //{
        //    int result = 0;
        //    int perSum = (A.Max() * (1 + A.Max())) / 2;
        //    if (A.Sum() == perSum)
        //    {
        //        result = 1;
        //    }
        //    return result;
        //}
    }
}