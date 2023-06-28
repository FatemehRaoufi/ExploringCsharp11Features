namespace ExploringCsharp11Features
{
    /// <summary>
    /// C# 11 expand scope of nameof expressions.
    /// We can specify the name of a method parameter in an attribute on the parameter declaration or method.
    /// This can be used in adding attributes for code analysis.
    /// </summary>
    internal class ExtendedNameOfScope
    {
        public ExtendedNameOfScope() { }

        [MyAttr(nameof(param))]
        public void Method(int param, [MyAttr(nameof(param))] int anotherParam)
        { }

    }
    public class MyAttr : Attribute
    {
        private readonly string _paramName;

        public MyAttr(string paramName)
        {
            _paramName = paramName;
        }
    }

  
}
