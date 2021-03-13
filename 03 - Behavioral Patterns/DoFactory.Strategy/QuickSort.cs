using System;
using System.Collections.Generic;

namespace DoFactory.BehavioralPatterns.Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class QuickSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}