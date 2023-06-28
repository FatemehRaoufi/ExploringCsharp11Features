namespace ExploringCsharp11Features
{
    /// <summary>
    /// C# 11 introduces the generic attributes.
    /// </summary>
    internal class GenericAttribute
    {
        public GenericAttribute()
        {


        }
    }
    //C# 10
    /*
    class MyType
    { }

    class MyAttribute : Attribute
    {
        private Type _type;

        public MyAttribute(Type type)
        {
            _type = type;
        }
    }

    [MyAttribute(typeof(MyType))]
    class Myclass { }
    */
    // C# 11
    class MyType
    { }

    class GenericAttribute<T> : Attribute
      where T : MyType
    {
        private T _type;
    }

    [GenericAttribute<MyType>]
    class MyClass
    { }
}
