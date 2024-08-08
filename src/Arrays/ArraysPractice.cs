using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ArraysPractice
    {
        /*Задан следующий трехмерный массив:
         С помощью циклов переберите все элементы этого массива и выведите их на консоль в следующем виде:
        {{{1 , 2} , {3 , 4}} , {{4 , 5} , {6 , 7}} , {{7 , 8}, {9 , 10}} , {{10 , 11} , {12 , 13}}}*/
        void IteratingArray()
        {
            int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
            int a = mas.GetUpperBound(0);
            int b = mas.GetUpperBound(1);
            int c = mas.GetUpperBound(2);

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("{");
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine("{");
                    for (int k = 0; k < c; k++)
                    {
                        Console.WriteLine(mas[i,j,k]);
                        Console.WriteLine(", ");
                    }
                    Console.WriteLine("}");

                    if (j < b) Console.WriteLine(",");
                }
                Console.WriteLine("}");

                if (i<a) Console.WriteLine(",");
            }
            Console.WriteLine("}");
        }
    }
}
