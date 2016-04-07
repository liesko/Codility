// https://codility.com/demo/results/demoU7ZGNN-FK8/ 44 percent
// sortovanie nie je potrebne, stačí preisť pole a vybrať 5 hodnot s ktorými potom budeme pracovať
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------");
            int[] A = { -2,-3,-4,-5,1};
            Console.WriteLine(solution(A));
            Console.ReadKey();
        }
        public static int solution(int[] A)
        {
            Array.Sort(A);
            // + + +
            if ((A[A.Length - 1] >= 0) && (A[A.Length - 2] >= 0) && (A[A.Length - 3] >= 0))
            {
                return A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            }
            // - + +
            if ( (A[A.Length - 1] >= 0) && ((A[A.Length - 2] ) >= 0) && (A[A.Length - 3] < 0))
            {
                return A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            }
            // - - + 
            if ( (A[A.Length - 1] >= 0) && ((A[A.Length - 2] ) < 0) && (A[A.Length - 3] < 0))
            {
                return A[A.Length - 1] * A[0] * A[1];
            }
            // - - -
            if ((A[A.Length - 1] < 0) && ((A[A.Length - 2] ) < 0) && (A[A.Length - 3] < 0))
            {
                return A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            }
            return 0;
        }
    }
}
