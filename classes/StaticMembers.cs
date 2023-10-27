namespace StaticMembers;

class Person
{
    /*
        # Static Field & Property
    
        A static field is bound to a class, not an instance of the class.
     */

    /*
        Instance field that is bound to an instance of the `Person` class.
        This is means that each instance of the `Person` class has its own `Name` field with separate value.
     */
    public string Name;

    /*
        Unlike an sinstance field, the compiler creates a separate memory location to store a static field once it encounters the `Person` class.
        Since the static field `Count` is bound to the `Person` class, not an instance of the class, you cannot use the `this` keyword to reference it.
     */
    public static int Count = 0;

    /*
        With a public `get` accessor and a private `set` accessor, you can change the `GetCount` property inside the class ans access it from both inside and outside of the class.
     */
    public static int GetCount { get; private set; }

    public Person(string name)
    {
        Name = name;
        Count++;
        GetCount++;
    }
}

class UnitConverter
{
    public static double KgToLbs(double weight) => weight * 2.20462262185;

    public static double LbsToKg(double weight) => weight * 0.45359237;

    /*
        # Static Methods

        Cannot access instance members of the class.

        To call a static method inside the class, use the static method name only.

        Syntax: StaticMethod(arguments);

        To call a static method outside the class, access the class first.

        Syntax: ClassName.StaticMethod();
     */
}

class RandomNumber
{
    /*
        # Static Constructor

        Cannot access instance members of the class.

        Generally, a static constructor initializes a static fields and properties.

        A static constructor is different from an instance constructor in the following ways:
        - A static constructor uses the static keyword in the class.
        - A class can have only one static constructor. And the static constructor cannot have any parameters.
        - Astatic constructor cannot have an access modifier like `public` or `private`.
     */

    private static Random random;

    static RandomNumber()
    {
        random = new Random();
    }

    public int Get() => random.Next();
}

static class LengthConverter
{
    /*
        # Static Classes

        A static class is a class that cannot be instaatiated.

        Typically, you use a static class to group members that are specific to a class, not an instance of the class.

        A common use of a static class is to create a utility class that contains a set of methods and values like the Math library.

        A static class has the following characteristics:
        - A static class declaration needs to have the `static` keyword.
        - A static class has only static members including static fields, properties, and methods.
        - A static class cannot have any instance constructor but can have a static constructor.
        - A static class is implicitly sealed. Therefore, you cannot subclass it.

        Starting from C# 6, you can access members of a static class without the class if you have a `using static` directive.
        
        For example:

        ```cs
        using static LengthConverter;

        double meters = FeetToMeters(100);
        ```
     */

    public static double RatioOfFeetAndMeters => 3.28084;

    public static double FeetToMeters(double ft) => ft / RatioOfFeetAndMeters;

    public static double MetersToFeet(double m) => m * RatioOfFeetAndMeters;
}
