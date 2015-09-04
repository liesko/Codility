/*
* my result: 88 % https://codility.com/demo/results/demoX7H4Y5-YGD/
* name: MaxCounters
* language: C#
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_MaxCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3};
            int N = 10;
            int[] result= new int[N];
            Array.Copy(solution(N,A), result, result.Length);
            foreach (int item in result) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static int[] solution(int N, int[] A)
        {
            int actual_max=0;
            int[] result = new int[N];
            Array.Clear(result, 0, result.Length);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= N)
                {
                    result[A[i]-1]++;
                    if (result[A[i]-1] > actual_max)
                    {
                        actual_max = result[A[i]-1];
                    }
                }

                if (A[i] == N + 1)
                {
                    for (int j = 0; j < result.Length; j++)
                    {
                        result[j] = actual_max;
                    }
                }
            }
            return result;
        }
    }
}
