using System;
using System.Collections.Generic;

namespace DoFactory.BehavioralPatterns.Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}