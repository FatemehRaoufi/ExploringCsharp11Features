namespace ExploringCsharp11Features
{
    internal class PatternMatchingSpanOnConstantString
    {
        public PatternMatchingSpanOnConstantString() {

            //C# 10

            /*
             ReadOnlySpan<char> strSpan = "SK".AsSpan();
             if (strSpan == "SK")
             {
                 Console.WriteLine("Hey, SK");
             }
            */

            // C# 11
            ReadOnlySpan<char> strSpan = "SK".AsSpan();
            if (strSpan is "SK")
            {
                Console.WriteLine("Hey, SK");
            }

        }

    }
}
