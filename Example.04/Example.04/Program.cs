using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array011 = new int[] { 7, 3 };
            MergeAlgorithmSimple.Merge(array011, 0, 1, 1);
            Console.WriteLine(ArrayToString(array011));

            int[] array001 = new int[] { 7, 3 };
            MergeAlgorithmSimple.Merge(array001, 0, 0, 1);
            Console.WriteLine(ArrayToString(array001));

            int[] sorted = MergeAlgorithmSimple.Merge(array011, 0, 1, 2);
            Console.WriteLine(ArrayToString(sorted));
        }

        public static string ArrayToString(int[] input)
        {
            string result = String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result = result + input[i] + " ";
            }
            if (input.Length == 0)
            {
                result = "Array is empty.";
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}