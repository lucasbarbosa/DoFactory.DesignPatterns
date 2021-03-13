﻿namespace DoFactory.StructuralPatterns.Flyweight
{
    /// <summary>
    /// The 'Flyweight' abstract class
    /// </summary>
    abstract class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        protected int pointSize;

        public abstract void Display(int pointSize);
    }
}