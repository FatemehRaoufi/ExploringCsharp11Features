
namespace ExploringCsharp11Features
{
    /// <summary>
    /// It expand pattern matching to match sequences of elements in a list or an array.
    ///You can use list patterns with any pattern, including property, type, constant, & relational patterns.
    /// </summary>
    internal class ListPatterns
    {
        public ListPatterns() 
        {
            var numbers = new[] { 1, 2, 3, 4 };
            // List and constant patterns 
            Console.WriteLine(numbers is [1, 2, 3, 4]); // True 
            Console.WriteLine(numbers is [1, 2, 4]); // False
                                                     // List and discard patterns 
            Console.WriteLine(numbers is [_, 2, _, 4]); // True 
            Console.WriteLine(numbers is [.., 3, _]); // True
                                                      // List and logical patterns 
            Console.WriteLine(numbers is [_, >= 2, _, _]); // True
        }
    }
}
