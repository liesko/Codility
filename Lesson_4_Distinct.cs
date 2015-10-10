// author: Anton Lieskovsky
// language> C#
// https://codility.com/demo/results/demoCB6NSW-ZGV/ 91 percent
// https://codility.com/demo/results/demoACVV96-VXW/ 100 percent
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            int[] A = { };
            Console.WriteLine(solution(A));
            Console.ReadKey();
        }
        public static int solution(int[] A)
        {
            if (A.Count() == 0) 
            {
                return 0;
            }
            int counter = 1;
            Array.Sort(A);
            for (int i = 0; i < A.Length-1; i++) 
            {
                if (A[i] != A[i + 1]) 
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
