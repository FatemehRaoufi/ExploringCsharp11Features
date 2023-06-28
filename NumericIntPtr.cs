using System.Runtime.InteropServices;

namespace ExploringCsharp11Features
{
    /// <summary>
    /// A little improvement in C# 11.
    /// The nint and nuint types now alias System.IntPtr and System.UIntPtr respectively.
    /// </summary>
    internal class NumericIntPtr
    {
        public NumericIntPtr() {

            string str = "Hello!";
            IntPtr intPtr = Marshal.StringToHGlobalAnsi(str);
            nint nInt = Marshal.StringToHGlobalAnsi(str);

            unsafe
            {
                byte* src = (byte*)intPtr.ToPointer();
                byte* dst = (byte*)nInt.ToPointer();
            }

        }

    }
}
