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
            //                          a  a  a  a  a  b  b  b  b  b
            int[] array09 = new int[] { 0, 2, 4, 6, 8, 1, 3, 5, 7, 9 };
            MergeAlgorithm.Merge(array09, 0, 4, 9);
            // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            Console.WriteLine(ArrayToString(array09));

            //                           a  a
            int[] array011 = new int[] { 7, 3 };
            MergeAlgorithm.Merge(array011, 0, 1, 1);
            // 7, 3
            Console.WriteLine(ArrayToString(array011));

            //                           a  b
            int[] array001 = new int[] { 7, 3 };
            MergeAlgorithm.Merge(array001, 0, 0, 1);
            // 3, 7
            Console.WriteLine(ArrayToString(array001));

            // 3, 7
            int[] sorted = MergeAlgorithmSimple.Merge(array011, 0, 1, 2);
            Console.WriteLine(ArrayToString(sorted));
        }

        public static string ArrayToString(int[] ints)
        {
            return string.Join(", ", ints.Select(x => x.ToString()).ToArray());
        }
    }
}