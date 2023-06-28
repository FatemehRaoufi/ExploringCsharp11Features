namespace ExploringCsharp11Features
{
    /// <summary>
    /// The C# 11 compiler itself initializes any property or field not initialized by a constructor in the structs.
    /// Such code doesn’t compile in the previous C# versions.
    /// The compiler sets the default values.
    /// </summary>
    internal class AutoDefaultStructs
    {

        /*
            C# 10:
           struct Person
           {
               // Auto-implemented property 'Person.Age 
               // must be fully assigned before control 
               // is returned to the caller. 
               public Person(string name)
               {
                   Name = name;
               }

               public string Name { get; set; }
               public int Age { get; set; }
           }
        */
        // C# 11:

        struct Person
        {
            public Person(string name)
            {
                Name = name;
            }

            public string Name { get; set; }
            public int Age { get; set; }
        }



    }
}
