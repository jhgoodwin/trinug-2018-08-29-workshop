using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._04
{
    internal class Queue
    {
        private int[] _array;
        private int _now;
        private int _last;

        internal Queue(int[] array, int now, int last)
        {
            _array = array;
            _now = now;
            _last = last;
        }

        internal bool empty() { return _now >= _last; }
        internal int top() { return _array[_now]; }
        internal int pop() { return _array[_now++]; }
        internal void push(int v) { _array[_last++] = v; }
    }

    class MergeAlgorithmSimple
    {

        public static int[] Merge(int[] input, int low, int middle, int high)
        {
            Queue left = new Queue(input, low, middle);
            Queue right = new Queue(input, middle, high);

            int[] arr = new int[high - low];
            Queue ret = new Queue(arr, 0, 0);

            while (!left.empty() || !right.empty())
            {
                Queue min;
                if (!left.empty() && !right.empty())
                {
                    min = left.top() < right.top() ? left: right;
                }
                else if (!left.empty())
                {
                    min = left;
                }
                else
                {
                    min = right;
                }

                ret.push(min.pop());
            }

            return arr;
        }
    }
}