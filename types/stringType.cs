using System.Text;

class StringType
{
    public StringType()
    {
        /*
            The `string` keyword is an alias for the `System.String` type. Therefore, the `string` and `String` are equivalent.
         */
        string msg; // Declaring a string variable without initializing it
        msg = "Hi"; // To assign a value to the string variable, you should place the string text inside double quotes

        string msg2 = "Hi"; // delcares and initializes the string simultaneously

        string msg3 = string.Empty; // create a zero-length string
        string msg4 = "";

        string msg5 = "Hello";
        Console.WriteLine(msg5.Length); // Access the Length property in order to get the length of a string

        string msg6 = msg5 + " Victor"; // Concatenate two strings into one

        string msg7 = msg6 += '!'; // Appending a string to another

        /*
            The String provide tou with `Join()` method that allows you to concatenate two or more strings into a single string using a separator.
         */
        string msg8 = string.Join(" ", "My", "friend", "is", "so", "cute"); // => My friend is so cute

        /*
            Besides the `+` operator, you can use the `Concat()` method to concatenate two or more strings into a string.
         */
        string msg9 = string.Concat('A', 'B', 'C', 'D'); // => ABCD
    }

    public static void Immutable()
    {
        /*
            You'll always get a new string when you make any changes to a string
         */
        string msg = "C#";
        msg += " string";

        Console.WriteLine(msg); // => C# string
    }

    public static void AccessingIndividual()
    {
        /*
            stringVariable[index]
         */
        string msg = "Hello";

        Console.WriteLine(msg[0]); // => H

        // msg[0] = 'h'; // Changing characters of a string may cause into a compilation error
    }

    public static void EscapeSequences()
    {
        string header = "id\tname"; // => id    name
        string msg = "\"C# is awesome.\" They said."; // => "C# is awesome." They said.
        string path = "C:\\users\\"; // => C:\users\
    }

    public static void Verbatim()
    {
        /*
            Turn a literal string into a verbatim string by prefixing the `@` symbol.
            The verbatim string disables escape characters so that a backslash is a backslash.
         */
        string path = @"C:\users\"; // => C:\users\

        // It also preserve newline characters as part of the string text
        string msg =
            @"
            Console.WriteLine('A');
        ";
    }

    public static void Interpolated()
    {
        /*
            Prefix the literal string with the `$` character and place the variable inside the curly braces `{}`.
         */
        string name = "Vic";
        Console.WriteLine($"Hello {name}!"); // => Hello Vic!
    }

    public static void Utf8()
    {
        /*
            The web uses UTF-8 as the character encoding. Each character takes 1 ~ 4 bytes.
            But in .NET, the string type uses UTF-16 by default. It means that each character takes at least 2 bytes in size.
            If you use C# to process characters for the web, you need to convert UTF-16 to UTF-8.
            Note that if you use ASP.NET Core, the framework does the conversion for you automatically.
         */
        var utf8 = Encoding.UTF8.GetBytes("Hello WWW"); // This manual conversion creates a big overhead and slow down the program

        var utf8_2 = "Hello WWW"u8; // C# 11 introduce the concept of UTF-8 string, it has a suffix of `u8` like this
    }

    public static void Raw()
    {
        /*
            C# 11 introduced raw string, which uses a flexible start and end delimiter to avoid conflict with the contents of the string.
            A raw string starts with a minimum of three quotes `"""` and is optionally followed by a new line, the content of the string, and ends with the same number of quotes.
         */
        var json = """{ "name": "Victor" }"""; // => { "name": "Victor" }

        /*
            If the string itself may use three quotes then the raw string can have longer starting/ending delimiters
         */
        var s = """"C# raw string uses a minimum of """ """"; // => C# raw string uses a minimum of """

        /*
            Raw string literals support multiline strings
            
            Rules of the multi-line raw string literals:
            - The opening and closing quotes of a multi-line raw string literal must be on separate lines.
            - Any whitespace following the opening quote on the same line is ignored.
            - Whitespace-only lines following the opening quotes are included in the string literal.
            - Any whitespace to the left of the closing quotes is removed from all lines of the raw string literal.
         */
        var json_2 = """
            {
                "name": "Victor Hsu",
                "address": {
                    "home": "some where on the Earth",
                    "work": "Sunrise"
                }
            }
        """;

        /*
            Raw string interpolation
            Prefixing the string with `$$` and surround the variable with double opening and closing curly braces `{{}}`.
         */
        var name = "Victor";
        var json_3 = $$""" { "name": "{{name}}" } """;
    }
}
