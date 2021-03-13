namespace DoFactory.BehavioralPatterns.Visitor
{
    /// <summary>
    /// The 'Element' abstract class
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}