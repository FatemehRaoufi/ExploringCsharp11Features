namespace ExploringCsharp11Features
{
    /// <summary>
    /// C# 11 introduces static abstract members in interfaces.
    /// We can add static abstract members in interfaces to define interfaces that include other static members, 
    /// overloadable operators, and static properties.
    /// </summary>
    internal class StaticAbstractMembersInInterfaces
    {
        public StaticAbstractMembersInInterfaces() { }

    }
    public interface IAdditionOperators<TSelf, TOther, TResult>
    where TSelf : IAdditionOperators<TSelf, TOther, TResult>
    {
        static abstract TResult operator +(TSelf left, TOther right);
    }
}
