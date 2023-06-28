
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;


namespace ExploringCsharp11Features
{
    /// <summary>
    /// C# 11 introduces a new required modifier to fields & properties to impose constructors & callers to initialize those values.
    ///A new SetsRequiredMembers attribute on the constructor tells the compiler that it initializes all required members.
    /// </summary>
    public class Person
    {
        public Person() { }

        [SetsRequiredMembers]
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public required string Name { get; set; }
        public required string Surname { get; set; }
    }
    internal class RequiredMembers
    {
        public RequiredMembers()
        {

            // Initializations with required properties 
            Person p1 = new Person { Name = "Shehryar", Surname = "Khan" };
            Person p2 = new("Shehryar", "Khan");

            // Initializations with missing required properties and showing Syntax error
            //Person p3 = new Person { Name = "Shehryar" };
            //Person p4 = new();
        }
    }


}
