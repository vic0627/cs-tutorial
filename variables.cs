class Variables
{
    /**
    * Data Types
    * int | 4 bytes | -2147483648 to 2147483647
    * long | 8 bytes | -9223372036854775808 to 9223372036854775807
    * float | 4 bytes | 6 to 7 decimal digits
    * double | 8 bytes | 15 decimal digits
    * bool | 1 bit | true / false
    * char | 2 bytes | single character/letter
    * string | 2 bytes per character | sequence of characters
    */

    // `int` - stores integers (whole numbers), without decimals, such as 123 or -123
    public int intergers;

    // `double` - stores floating point numbers, with decimals, such as 19.99 or -19.99
    public double floatingPointNumbers;

    // `char` - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
    public char singleCharacter;

    // `string` - stores text, such as "Hello World". String values are surrounded by double quotes
    public string text = "";

    // `bool` - stores values with two states: true / false
    public bool boolean;

    public Variables()
    {
        intergers = 100;
        floatingPointNumbers = 0.000001;
        singleCharacter = 'A';
        text = "Hello World!";
        boolean = true;
    }

    /**
    * Declaring Variables
    * Syntax:
    *   type variableName = value;
    */

    public static void Declare()
    {
        // number
        int x = 1,
            y,
            z;
        long l = 1500000000000L;
        double i = 0.123;
        float f = 5.15F;

        // text
        char c = 'V';
        string t = "Hello";

        // state
        bool b = false;

        y = z = 3;

        Console.WriteLine(x + y + z + i);

        Console.WriteLine(t + " Victor");
        Console.WriteLine($"{t} Yvonne");
    }

    /**
    * Constants
    * Add the `const` keyword in front of the variable type can make the variable be unchangeable and read-only.
    * A const field requires a vlaue to be provided.
    * C# only allows you to use built-in types except for the `object` as constants.
    * Keyword `const` can be used in both method and class.
    */

    public static void Constants()
    {
        const double PI = 3.1415926;
        Console.WriteLine(PI);
    }

    /**
    * Type Casting
    * `Implicit Casting (automatically)` - converting a smaller type to a lager type size
    *   char => int => long => float => double
    *
    * `Explicit Casting (manually)` - converting a larger type to a smaller size type
    *   double => float => long => int => char
    */

    public static void Casting()
    {
        // Implicit Casting
        int a = 9;
        double b = a;

        Console.WriteLine(b);

        // Explicit Casting
        double c = 9.87;
        int d = (int)c;

        Console.WriteLine(d);

        // Type Conversion Methods
        Console.WriteLine(Convert.ToString(a));
        Console.WriteLine(Convert.ToDouble(a));
        Console.WriteLine(Convert.ToInt32(b)); // to int
        Console.WriteLine(Convert.ToInt64(a)); // to long
        Console.WriteLine(Convert.ToBoolean(a));
    }
}
