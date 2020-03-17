using System;
using System.Collections.Generic;
using System.Linq;

namespace advancedCoarse.generics
{
    public class Utilities
    {
        public Utilities()
        {
        }

        public T Max<T>(T a, T b) where T : IComparable =>
            a.CompareTo(b) > 0 ? a : b;

        // DELEGATES
        Func<int, int> squareNumber = (num) => num * num;

        // Codewars
        public int[] Pendulum(int[] values)
        {
            var result = new List<int>();
            var valuesOrdered = values.OrderBy(v => v).ToArray();
            for (int i = 0; i < valuesOrdered.Length; i++)
            {
                Console.WriteLine("i: "+ valuesOrdered[i]);
                if (i == 0) result.Add(valuesOrdered[i]);
                else if (i % 2 != 0) result.Insert(result.Count , valuesOrdered[i]);
                else result.Insert(0, valuesOrdered[i]);
            }
            return result.ToArray();
        }


    }
}

//public class DiscountCalcultor

// where T : IComparable
// where T : Product
// where T : struct
// where T : class
// where T : new()
