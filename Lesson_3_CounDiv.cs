/*
* task: Lesson_3_CounDiv
* my result: 87% https://codility.com/demo/results/demoHFAHK2-GDU/
* language C#
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_CounDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(solution(11,375,17));
            Console.ReadKey();
        }
        public static int solution(int A, int B, int K)
        {
            if((A%K==0)&&(B%K==0))
            {
                return ((B - A) / K) + 1;
            }
            if ((A % K == 0) || (B % K == 0))
            {
                return ((B - A) / K) + 1;
            }
            if ((A % K != 0) || (B % K != 0))
            {
                return (B - A)/K;
            }
            return 0;
        }
    }
}
