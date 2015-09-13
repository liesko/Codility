/*
* language: C# 
* my result: 62% (some problem with performance) https://codility.com/demo/results/demo3DKTE5-PHQ/
* Codility task: Lesson_3_GenomicRangeQuery
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_GenomicRangeQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Ahoj";
            Console.WriteLine(test[0].ToString());
            Console.WriteLine("---------------------");
            string S = "CAGCCTA";
            int[] P={2,5,0};
            int[] Q={4,5,6};
            Console.WriteLine(solution(S,P,Q).ToString());
            Console.ReadKey();
        }
        public static int[] solution(string S, int[] P, int[] Q)
        {
            int[] result = new int[P.Length];
            int[,] mapper=new int[S.Length,4];
            // mapovacia cast
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i].ToString() == "A") { mapper[i,0] = 1; }
                if (S[i].ToString() == "C") { mapper[i,1] = 1; }
                if (S[i].ToString() == "G") { mapper[i,2] = 1; }
                if (S[i].ToString() == "T") { mapper[i,3] = 1; }
            }
            
            int x, y;
            int suma = 0;
            for (int j = 0; j < P.Length; j++) 
            {
                x = P[j];
                y = Q[j];
                suma = 0;
                for (int q = 0; q < 4; q++)
                {
                    while((x <= y)&&(suma==0))
                    {
                        suma += suma + mapper[x, q];
                        result[j] = (suma != 0) ? q+1 : 0;
                        x++;
                    }
                    x = P[j];
                }
                if (suma != 0)
                {
                    continue;
                }
            }
            return result;
        }
    }
}
