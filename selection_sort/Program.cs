using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    class sorting
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 76, 16, 99, 67, 87, 43, 24, 12, 78, 34 };
            int n = 10;
            Console.WriteLine("selection sort:");
            Console.Write("initial array is: \n");
            for (int i = 0; i < n; i++)
            { Console.Write(array[i] + "\n"); }

            int temporary, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[smallest])
                    { smallest = j; }
                }
                temporary = array[smallest];
                array[smallest] = array[i];
                array[i] = temporary;


            }

            
            Console.Write("sorted array is: \n");
            for (int i = 0; i < n; i++)
            { Console.Write(array[i] +"\n"); }
            Console.ReadKey();
        }
    }
}
