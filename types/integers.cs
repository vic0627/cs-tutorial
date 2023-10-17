class Integers
{
    public Integers()
    {
        /*
            The characteristics of all the integers types in C#:
         */
        sbyte a = -128; // -128 ~ 127 | signed 8-bit integer
        byte b = 255; // 0 ~ 255 | unsigned 8-bit integer
        short c = -32768; // -32768 ~ 32767 | signed 16-bit integer
        ushort d = 65535; // 0 ~ 65535 | unsigned 16-bit integer
        int e = -2147483648; //  -2147483648 ~ 2147483647 | signed 32-bit integer
        uint f = 4294967295; // 0 ~ 4294967295 | unsigned 32-bit integer
        long g = -9223372036854775808; // -9223372036854775808 ~ 9223372036854775807 | signed 64-bit integer
        ulong h = 0; // 0 ~ 18446744073709551615 | unsigned 64-bit integer
    }

    public static void MinAndMax()
    {
        /*
            Each integer type has the `MinValue` and `MaxValue` constants that provide the minimum and maximum of the type.
         */
        const int intMin = int.MinValue;
        const int intMax = int.MaxValue;

        Console.WriteLine($"int range: ({intMin}, {intMax})");
    }

    public static void IntegerLiterals()
    {
        /*
            Digit separator (_)
         */
        int a = 1_000_000;

        /*
            Hexadecimal numbers have the `0x` or `0X` prefix
         */
        int hex = 0xfff;

        /*
           Binary numbers have the `0b` or `0B` prefix
         */
        int bin = 0b1011;
        // or
        int bin2 = 0b_1011_0100;
    }
}
