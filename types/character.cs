class Character
{
    public Character()
    {
        /*
            A variable of the `char` typq can hold a single character.
            The `char` is an alias for the .NET `System.Char` type.
         */

        // three ways to represent a character literal:
        char a = 'a'; // character
        char b = '\u002B'; // A Unicode escape sequence starts with `\u` and is followed by a four-symbol hexadecimal representation of the character code.
        char c = '\x002C'; // A hexadecimal escape sequence starts with `\x` and the hexadecimal representation of the character code.
    }

    public static void Operators()
    {
        /*
            The `char` type support equality, comparision, increment, and decrement operators.
         */
        char c1 = 'a',
            c2 = 'b';
        bool res = c1 == c2;
        Console.WriteLine(res); // false

        bool res2 = c1 < c2;
        Console.WriteLine(res2); // true
    }
}
