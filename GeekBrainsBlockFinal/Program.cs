using System;

namespace GeekBrainsBlockFinal
{
    class Program
    {
        static string[] my_string_array_test = { "732", "hello", "-)", "test", "3", "www" };

        static int flag = 3;

        static int CheckArray(string[] array)
        {
            int n = 0;
            foreach (string x in array)
            {
                if (x.Length <= flag)
                {
                    n++;
                }
            }

            return n;
        }
        static string[] CreateNewStringArray(int n)
        {
            string[] str_array_with_three_chars_empty = new string[n];

            return str_array_with_three_chars_empty;
        }
        static string[] FillEmptyArray(string[] array, string[] empty_array)
        {
            int i = 0;
            foreach (string x in array)
            {
                if (x.Length <= flag)
                {
                    empty_array.SetValue(x, i);
                    i++;
                }
            }
            string[] str_array_with_three_chars = empty_array;
            return str_array_with_three_chars;
        }

        static void PrintArray(string[] array)
        {
            foreach (string x in array)
            {
                Console.Write($"{ x } \t");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
