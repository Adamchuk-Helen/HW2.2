using System;
using System.Linq;

namespace HW2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] arr1 = new int[5] { 44, 8, 32, 99, 67 };
            int[] arr2 = new int[5] { 8, 99, 76, 99, 22 };

            Console.WriteLine("\nПерший масив");
            foreach (int i in arr1)
            { Console.WriteLine(i); }

            Console.WriteLine("\nДругий масив");
            foreach (int i in arr2)
            { Console.WriteLine(i); }

            //отримує 2 одновимірні масиви та повертає масив, що містить елементи обох масивів
            //(для копіювання елементів можна скористатися методом CopyTo, arr.CopyTo(arr2, position))

            int[] arr3 = new int[10];
            arr1.CopyTo(arr3, 0);
            arr2.CopyTo(arr3, 5);
            Console.WriteLine("\nМасив, що містить елементи двох попередніх масивів");
            foreach (int i in arr3)
            {
                Console.WriteLine(i);
            }
            //отримує 2 одновимірні масиви та повертає масив з спільними елементами
            int value;
            int j = 0;
            int[] arr4 = new int[0];
            for (int i = 0; i < arr2.Length; i++)
            {

                if (Array.Exists(arr1, element => element == arr2[i]))
                {
                    value = arr2[i];
                    Array.Resize(ref arr4, j + 1);
                    arr4[j] = value;
                    j++;

                }
            }

            int[] arr5 = arr4.Distinct().ToArray();

            Console.WriteLine("\nМасив, повертає масив з спільними елементами двох перших  масивів (без повторів)");
            
            foreach (int i in arr5)
            { Console.WriteLine(i); }

            //-отримує 2 одновимірні масиви та повертає масив, що містить елементи першого масиву, що НЕ зустрічаються у другому

            int[] arr6 = new int[0];
            int m = 0;
            
            for (int i = 0; i < arr1.Length; i++)
            {


                if (Array.Exists(arr2, element => arr1[i] == element))
                {
                    continue;
                }
                else
                {
                    value = arr1[i];
                    Array.Resize(ref arr6, m + 1);
                    arr6[m] = value;
                    m++;
                }

            }
            Console.WriteLine("\nМасив, що містить елементи першого масиву, що НЕ зустрічаються у другому");

            foreach (int i in arr6)
            { Console.WriteLine(i); }

        }

    }
}

