﻿using System;

namespace DoFactory.StructuralPatterns.Flyweight
{
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    class CharacterB : Character
    {
        // Constructor
        public CharacterB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }

        public override void Display(int pointSize)
        {
            this.pointSize = pointSize;
            Console.WriteLine(this.symbol + " (pointsize " + this.pointSize + ")");
        }
    }
}