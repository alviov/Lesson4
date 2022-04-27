using System;
using System.Collections;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("insert array a[] dimension");
            var s = Console.ReadLine();
            int[] intArray = new int[] { };
            int dim = 0;
            bool test = false;

            while (!test)
            {
                if (int.TryParse(s, out int j))
                {
                    try
                    {
                        dim = j;
                        intArray = new int[dim];
                        test = false;
                        if (dim < 2) throw new ArgumentException();
                        test = true;
                    }

                    catch (OverflowException)
                    {
                        Console.WriteLine($"wrong dimension, it should be above zero");
                        Console.WriteLine("insert array a[] dimension");
                        s = Console.ReadLine();
                        test = false;
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine($"wrong dimension, it should be at least 2 or more");
                        Console.WriteLine("insert array a[] dimension");
                        s = Console.ReadLine();
                        test = false;
                    }

                }
                else
                {
                    Console.WriteLine("Wrong dimension, write integer type");
                    Console.WriteLine("insert array a[] dimension");
                    s = Console.ReadLine();
                    test = false;
                }
            }

            for (int i=0;i<dim;i++)
            {
                test = false;

                while (!test)
                {
                    Console.WriteLine($"insert array[{i}] element");

                    var element = Console.ReadLine();

                    if (int.TryParse(element, out int j))
                    {
                        intArray[i] = j;
                        test = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong element, write integer type");
                        test = false;
                    }
                }

            }

            Array.Sort(intArray);

            if (intArray[dim-1] == intArray[0])
                Console.WriteLine("All array elements are the same. There are no SECOND high number");

            for (int i = dim-1; i >= 0; i--)
            {
                if (intArray[i]<intArray[dim-1])
                {
                    Console.WriteLine($"second high number in array is {intArray[i]}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
