﻿namespace DoFactory.BehavioralPatterns.Memento
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    class ProspectMemory
    {
        private Memento _memento;

        // Property
        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}