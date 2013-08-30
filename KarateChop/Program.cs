using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateChop
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int EasyChop(int value, int[] ints)
        {
            return Array.IndexOf(ints, value);
        }

        public static int IterativeChop(int value, int[] ints)
        {
            int length = ints.Length;
            if (length == 0)
                return -1;

            int upper = length, lower = 0, i = length / 2;

            while (true)
            {
                int compared = value.CompareTo(ints[i]);
                if (compared == 0)
                    return i;
                if (i == upper || i == lower)
                    return -1;
                if (compared < 0)
                {
                    upper = i;
                    i = (i - lower) / 2;
                }
                else
                {
                    lower = i;
                    i = (i + upper) / 2;
                }
            }
        }

        public static int RecursiveChop(int value, int[] ints)
        {
            int length = ints.Length;
            if (length == 0)
                return -1;

            int i = length / 2;
            int middle = ints[i];
            int compared = value.CompareTo(middle);
            if (compared == 0)
                return i;
            if (compared < 0)
            {
                int[] firstHalf = ints.Take(i).ToArray();
                return RecursiveChop(value, firstHalf);
            }
            int[] secondHalf = ints.Skip(i + 1).ToArray();
            int result = RecursiveChop(value, secondHalf);
            if (result == -1) return -1;
            return i + result + 1;
        }
    }
}
