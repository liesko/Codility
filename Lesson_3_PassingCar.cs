/*
* language: C#
* my solution: 66% https://codility.com/demo/results/demoKDSFMS-BH4/ 66
* task: Lesson_3_PassingCar
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_PassingCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            int[] A = { 0,1};
            Console.WriteLine(solution(A));
            Console.ReadKey();

        }
        public static int solution(int[] A)
        {
            int pocet_jednotiek = A.Sum();
            int pocet_nul = A.Length-pocet_jednotiek;
            int suma = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    suma = suma + pocet_jednotiek;
                }
                else 
                {
                    pocet_jednotiek--;
                }
            }

            return suma;
        }
    }
}
