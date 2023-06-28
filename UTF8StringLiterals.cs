
namespace ExploringCsharp11Features
{
    internal class UTF8StringLiterals
    {
        /// <summary>
        ///UTF-8 string literals:
        ///It allows converting only UTF-8 characters to their byte representation at compile time.
        /// </summary>
        public UTF8StringLiterals() {

            //C10:
            //byte[] array1 = Encoding.UTF8.GetBytes("Hello World");
            //C11:
            //byte[] array2 = "Hello World";
            ReadOnlySpan<byte> span = "Anthony Giretti"u8;
            byte[] bytes = "Anthony Giretti"u8.ToArray();

        }


       
    }
}
/*
        Note that the ReadOnlySpan<byte> or byte[] types are enforced at compile time BUT UTF-8 strings aren’t compile time constants, 
        so it means they can’t be used as default parameters in functions and will lead to a comilation error
       
        Error CS1736 Default parameter value for ‘message’ must be a compile-time constant.
        // Error CS1736	Default parameter value for 'message' must be a compile-time constant
           void MyFunction(ReadOnlySpan<byte> message = "Anthony Giretti"u8)
           {

           }

       // Error CS1736	Default parameter value for 'message' must be a compile-time constant
           void MyFunction2(byte[] message = "Anthony Giretti"u8.ToArray())
           {

           }
        */

//https://anthonygiretti.com/2022/12/04/introducing-c11-utf-8-string-literals/