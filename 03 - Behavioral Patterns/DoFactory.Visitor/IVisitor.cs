namespace DoFactory.BehavioralPatterns.Visitor
{
    /// <summary>
    /// The 'Visitor' interface
    /// </summary>
    interface IVisitor
    {
        void Visit(Element element);
    }
}