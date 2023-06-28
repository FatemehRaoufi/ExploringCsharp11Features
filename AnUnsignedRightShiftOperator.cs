namespace ExploringCsharp11Features
{
    /// <summary>
    /// C# 11 introduces an unsigned right-shift operator >>>.
    /// It shifts bits right without replicating the high order bit on each shift.
    /// </summary>
    internal class AnUnsignedRightShiftOperator
    {
        public AnUnsignedRightShiftOperator()
        {
            int n = -32;
            Console.WriteLine($"Before shift: bin = {Convert.ToString(n, 2),32}, dec = {n}");

            int a = n >> 2;
            Console.WriteLine($"After >>: bin = {Convert.ToString(a, 2),32}, dec = {a}");

            int b = n >>> 2;
            Console.WriteLine($"After >>>: bin = {Convert.ToString(b, 2),32}, dec = {b}");

            // Output: 
            // Before shift: bin = 11111111111111111111111111100000, dec = -32 
            // After >>: bin = 11111111111111111111111111111000, dec = -8 
            // After >>>: bin = 111111111111111111111111111000, dec = 1073741816
        }
    }
}
