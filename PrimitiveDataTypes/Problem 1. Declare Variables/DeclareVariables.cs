using System;

class DeclareVariables
{
    static void Main()
    {
        ushort a = 52130;      // A small unsigned number (up to 65535)
        sbyte d = -115;        // A small signed number (greater than -128 and less than 127)
        uint m = 4825932;      // A large unsigned number (up to 4.3 billions)
        byte n = 97;           // A small unsigned number (up to 255)
        short p = -10000;       // A small signed number (greater than -32768 and less than 32767)
        Console.WriteLine(a);
        Console.WriteLine(d);
        Console.WriteLine(m);
        Console.WriteLine(n);
        Console.WriteLine(p);
    }
}